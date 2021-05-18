using System;
using System.Globalization;

namespace RecruTask
{
    public class DateConverter
    {
        Messenger messenger = new Messenger();
        DateTime userDate;

        public DateTime DateConvertion(string date, DateTimeFormatInfo dateTimeFormatInfo)
        {
            
            if (DateTime.TryParse(date,dateTimeFormatInfo, DateTimeStyles.NoCurrentDateDefault, out userDate))
            {

                return userDate;
            }
            else
            {
                Console.WriteLine(messenger.MessageIncorrectValue());
                return userDate;
            }

        }


    }
}
