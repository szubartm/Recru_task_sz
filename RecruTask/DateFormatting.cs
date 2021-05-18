using System;
using System.Globalization;


namespace RecruTask
{
    public class DateFormatting
    {
        
        DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;


        public string DateToString(DateTime userDateFirst, DateTime userDateSecond)
        {
            
            DateTime errorDate = new DateTime(0001, 01, 01 );
            if (userDateFirst == userDateSecond && userDateFirst!=errorDate && userDateFirst!=errorDate)
            {
                return userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            }
            else if (userDateFirst.Year != userDateSecond.Year)
            {
                if (userDateFirst.Year < userDateSecond.Year)
                {
                    return userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);

                }
                
                    return userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                

            }
            else if (userDateFirst.Month != userDateSecond.Month)
            {

                if (userDateFirst.Month < userDateSecond.Month)
                {
                    return userDateFirst.ToString("dd.MM", currentCultureDatetimeFormat) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
                
                    return userDateSecond .ToString("dd.MM", currentCultureDatetimeFormat) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                
            }
            else if (userDateFirst.Day != userDateSecond.Day)
            {
                if (userDateFirst.Day < userDateSecond.Day)
                {
                    return userDateFirst.ToString("dd", currentCultureDatetimeFormat) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                }
                
                   return userDateSecond.ToString("dd", currentCultureDatetimeFormat) + "-" + userDateFirst.ToString(currentCultureDatetimeFormat.ShortDatePattern);
                
            }
            return null;



        }
    }
}
