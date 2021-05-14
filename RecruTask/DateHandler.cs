using System;
using System.Globalization;

namespace RecruTask
{
    public class DateHandler
    {

        Messenger messenger = new Messenger();

        DateFormatChecker dateFormatChecker = new DateFormatChecker();

        DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;

        DateTime userDate;


        public DateTime DateConverter(string date)
        {


            bool isUS = false;

            if (!isUS)
            {
                if (dateFormatChecker.CheckIfCurrentFormatForDate(date))
                {
                    var dateHandlerCurrentCulture = new DateHandlerCurrentCulture();
                    userDate = dateHandlerCurrentCulture.DateConverterForCurrentCulture(date);
                    return userDate;
                }
                else
                {

                    isUS = true;
                }


            }

            if (isUS)

            {
                if (dateFormatChecker.CheckIfUSFormatForDate(date))
                {
                    var dateHandlerForUS = new DateHandlerForUS();
                    userDate = dateHandlerForUS.DateConverterForUS(date);
                    return userDate;

                }
                else
                {
                    Console.WriteLine(messenger.MessageIncorrectDateFormat());

                }

            }
            throw new Exception(messenger.MessageIncorrectValue());
        }



        public string DatePrinter(DateTime userDateFirst, DateTime userDateSecond)
        {
            string toPrint = null;
            if (userDateFirst == userDateSecond)
            {
                Console.WriteLine(messenger.MessageTheSameValue());
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
            else
            {
                toPrint = userDateFirst.ToString("dd", currentCultureDatetimeFormat) + "-" + userDateSecond.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            }

            return toPrint;
        }

    }
}
