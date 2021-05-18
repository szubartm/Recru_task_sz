using System;
using System.Globalization;

namespace RecruTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateConverter dateConverter = new DateConverter();
            DatePrinter datePrinter = new DatePrinter();
            FormatHandler formatHandler = new FormatHandler();
            DateFormats dateFormats = new DateFormats();
            Messenger messenger = new Messenger();
    
            DateTimeFormatInfo cultureFormatInfo;
            string result = null;
 
            Console.WriteLine(messenger.MessageBeginning());
            if (Console.ReadLine().Equals("yes"))
            {
                dateFormats.ShowAllDateFormats();
                Console.WriteLine("");
                Console.WriteLine(messenger.MessageTypeFormatShortcut());
                result = Console.ReadLine();

            }

            cultureFormatInfo = formatHandler.DateFormatInfo(result);
            
            Console.WriteLine(messenger.MessageEnterDate());
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();
           
            var finalDate = datePrinter.DatePrinting(dateConverter.DateConvertion(date1, cultureFormatInfo), dateConverter.DateConvertion(date2, cultureFormatInfo));
            Console.WriteLine(finalDate);
           
            
            Console.ReadLine();

        }
    }
}