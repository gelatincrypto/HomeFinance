using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HomeFinance.UI.Attribute
{
    public class FromDateToNowAttribute : ValidationAttribute
    {
        public string DateFrom { get; set; }

        public override bool IsValid(object value)
        {
            var date = (DateTime)value;
            var startDate = DateTime.Parse(DateFrom, CultureInfo.InvariantCulture);
            return DateTime.Compare(date, DateTime.Now) <= 0 && DateTime.Compare(date, startDate) >= 0;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.InvariantCulture, ErrorMessageString, name, DateFrom);
        }
    }
}