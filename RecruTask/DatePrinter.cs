using System;
using System.Globalization;


namespace RecruTask
{
    public class DatePrinter
    {
        
        DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;


        public string DatePrinting(DateTime userDateFirst, DateTime userDateSecond)
        {
            string toPrint = null;
            DateTime errorDate = new DateTime(0001, 01, 01 );
            if (userDateFirst == userDateSecond && userDateFirst!=errorDate && userDateFirst!=errorDate)
            {
                toPrint = userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            }
            else if (userDateFirst.Year != userDateSecond.Year)
            {
                if (userDateFirst.Year < userDateSecond.Year)
                {
                    toPrint = userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);

                }
                else
                {
                    toPrint = userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }

            }
            else if (userDateFirst.Month != userDateSecond.Month)
            {

                if (userDateFirst.Month < userDateSecond.Month)
                {
                    toPrint = userDateFirst.ToString("dd.MM", currentCultureDatetimeFormat) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
                else
                {
                    toPrint = userDateSecond.ToString("dd.MM", currentCultureDatetimeFormat) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
            }
            else if (userDateFirst.Day != userDateSecond.Day)
            {
                if (userDateFirst.Day < userDateSecond.Day)
                {
                    toPrint = userDateFirst.ToString("dd", currentCultureDatetimeFormat) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
                else
                {
                    toPrint = userDateSecond.ToString("dd", currentCultureDatetimeFormat) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
            }
            

            return toPrint;
        }
    }
}
