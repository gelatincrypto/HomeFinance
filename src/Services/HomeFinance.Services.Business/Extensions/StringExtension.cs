using System;
using System.Globalization;

namespace HomeFinance.Services.Business.Extensions
{
    public static class StringExtension
    {
        public static DateTime ToInvariantCultureDate(this string date)
        {
            return DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}