using System;

namespace RecruTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateHandler dateHandler = new DateHandler();
            DateFormatChecker dateFormatChecker = new DateFormatChecker();
            Messenger messenger = new Messenger();
            string us = null;
            bool isUS = false;
            string date1 = null;
            string date2 = null;




            Console.WriteLine("Enter a date: ");
            date1 = Console.ReadLine();
            date2 = Console.ReadLine();


            var finalDate = dateHandler.DatePrinter(dateHandler.DateConverter(date1), dateHandler.DateConverter(date2));
            Console.WriteLine(finalDate);
            Console.ReadLine();



        }
    }
}