using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class DateHandlerTests
    {
        [TestMethod]
        public void DateConverter_isUSTrue_USFormatCorrect_ReturnCorrectUserData()
        {
            DateFormatChecker dateFormatChecker = new DateFormatChecker();
           
            DateTime userDate;
            string date = "12/31/2021";
            DateTime expectedUserDate = new DateTime(2021,12,31);
            bool isUS = true;
            DateHandler dateHandler = new DateHandler();

            var result = dateHandler.DateConverter(date);

            Assert.AreEqual( expectedUserDate, result);

        }

        [TestMethod]
        public void DateConverter_isUSTrue_USFormatIncorrect_ReturnInCurrentCultureFormat()
        {
            DateFormatChecker dateFormatChecker = new DateFormatChecker();

            DateTime userDate;
            string date = "31/12/2021";
            DateTime expectedUserDate = new DateTime(2021, 12, 31);
            bool isUS = true;
            DateHandler dateHandler = new DateHandler();

            var result = dateHandler.DateConverter(date);

            Assert.AreEqual(expectedUserDate, result);
        }
    }
}
