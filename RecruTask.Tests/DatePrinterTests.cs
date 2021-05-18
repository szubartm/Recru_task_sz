using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class DatePrinterTests
    {
        [TestMethod]
        public void DatePrinting_SameDate_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2020, 12, 10);
            DateTime dateTime2 = new DateTime(2020, 12, 10);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime1.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DatePrinting_FirstYearBiggerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2021, 12, 10);
            DateTime dateTime2 = new DateTime(2020, 11, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime2.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + dateTime1.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DatePrinting_FirstYearLowerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2019, 12, 10);
            DateTime dateTime2 = new DateTime(2020, 11, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime1.ToString(currentCultureDatetimeFormat.ShortDatePattern) + "-" + dateTime2.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DatePrinting_FirstMonthBiggerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2020, 12, 10);
            DateTime dateTime2 = new DateTime(2020, 11, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime2.ToString("dd.MM", currentCultureDatetimeFormat) + "-" + dateTime1.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void DatePrinting_FirstMonthLowerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2020, 09, 10);
            DateTime dateTime2 = new DateTime(2020, 11, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime1.ToString("dd.MM", currentCultureDatetimeFormat) + "-" + dateTime2.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DatePrinting_FirstDayLowerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2020, 09, 10);
            DateTime dateTime2 = new DateTime(2020, 09, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime1.ToString("dd", currentCultureDatetimeFormat) + "-" + dateTime2.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DatePrinting_FirstDayBiggerThanSecond_CorrectReturn()
        {
            DateTime dateTime1 = new DateTime(2020, 09, 12);
            DateTime dateTime2 = new DateTime(2020, 09, 11);
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string expectedResult = dateTime2.ToString("dd", currentCultureDatetimeFormat) + "-" + dateTime1.ToString(currentCultureDatetimeFormat.ShortDatePattern);
            DatePrinter datePrinter = new DatePrinter();

            string result = datePrinter.DatePrinting(dateTime1, dateTime2);


            Assert.AreEqual(expectedResult, result);
        }
    }
}
