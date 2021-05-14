using System;
using System.Globalization;

namespace RecruTask
{
    public class DateFormatChecker
    {
        DateTimeFormatInfo usCultureDateTimeFormat = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
        DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;

        DateTime userDateTime1;



        public bool CheckIfUSFormatForDate(string date1)
        {
            if (DateTime.TryParse(date1, usCultureDateTimeFormat, DateTimeStyles.None, out userDateTime1))
            {
                return true;

            }
            else
            {
                return false;

            }
        }



        public bool CheckIfCurrentFormatForDate(string date1)
        {
            if (DateTime.TryParse(date1, currentCultureDatetimeFormat, DateTimeStyles.NoCurrentDateDefault, out userDateTime1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
