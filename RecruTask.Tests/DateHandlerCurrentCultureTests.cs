using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class DateHandlerCurrentCultureTests
    {

        [TestMethod]
        public void DateConverterForCurrentCulture_CorrectString_ReturnCorrectDate()
        {
            DateTimeFormatInfo currentCultureDatetimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            DateTime userDate;
            string date = "11.10.2021";
            DateTime expectedUserDate = new DateTime(2021, 10, 11);

            DateTime.TryParse(date, currentCultureDatetimeFormat, DateTimeStyles.NoCurrentDateDefault, out userDate);
            date = userDate.ToString();

            Assert.AreEqual(date, expectedUserDate.ToString());

        }
    }
}
