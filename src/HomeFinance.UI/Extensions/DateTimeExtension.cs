using System;
using System.Globalization;

namespace HomeFinance.UI.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToInvariantCultureString(this DateTime date)
        {
            return date.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}