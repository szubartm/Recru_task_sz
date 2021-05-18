using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class DateConverterTests
    {

        [TestMethod]
        public void DateConverter_CurrentCulture_ReturnCorrectDate()
        {

            DateTimeFormatInfo dateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo;
            DateConverter dateConverter = new DateConverter();
            DateTime userDate;
            DateTime expectedUserDate = new DateTime(2021, 10, 11);
            string date = "11.10.2021";

            userDate = dateConverter.DateConvertion(date, dateTimeFormatInfo);
                       
            Assert.AreEqual(userDate, expectedUserDate);

        }
        [TestMethod]
        public void DateConverter_USCulture_ReturnCorrectDate()
        {
            DateTimeFormatInfo dateTimeFormatInfo = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            DateConverter dateConverter = new DateConverter();
            DateTime userDate;
            DateTime expectedUserDate = new DateTime(2021, 11, 10);
            string date = "11.10.2021";

            userDate = dateConverter.DateConvertion(date, dateTimeFormatInfo);

            Assert.AreEqual(userDate, expectedUserDate);
        }

        [TestMethod]
        public void DateConverter_WrongValue_ReturnCorrectDate()
        {
            DateTimeFormatInfo dateTimeFormatInfo = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            DateConverter dateConverter = new DateConverter();
            DateTime userDate;
            DateTime expectedUserDate = new DateTime(0001,01,01);
            string date = "000000";

            userDate = dateConverter.DateConvertion(date, dateTimeFormatInfo);

            Assert.AreEqual(userDate, expectedUserDate);
        }
    }
}
