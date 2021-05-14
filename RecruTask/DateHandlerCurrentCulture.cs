using System;
using System.Globalization;

namespace RecruTask
{
    class DateHandlerCurrentCulture
    {

        Messenger messenger = new Messenger();

        DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;

        DateTime userDate;

        public DateTime DateConverterForCurrentCulture(string date)
        {
            if (DateTime.TryParse(date, currentCultureDatetimeFormat, DateTimeStyles.NoCurrentDateDefault, out userDate))
            {

            }
            else
            {
                Console.WriteLine(messenger.MessageIncorrectValue());
            }
            return userDate;
        }


    }
}
