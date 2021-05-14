using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruTask
{
    public class DateHandlerForUS
    {
        DateTimeFormatInfo usCultureDateTimeFormat = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
        DateTime userDateTime1;
       
        Messenger messenger = new Messenger();
        DateFormatChecker dateFormatChecker = new DateFormatChecker();

        public DateTime DateConverterForUS(String date1)
        {



            if (dateFormatChecker.CheckIfUSFormatForDate(date1))
            {
                DateTime.TryParse(date1, usCultureDateTimeFormat, DateTimeStyles.None, out userDateTime1);
                
                
            }
            else
            {
                Console.WriteLine(messenger.MessageIncorrectDateFormat());
                
            }

            return userDateTime1;
        }



    }
}
