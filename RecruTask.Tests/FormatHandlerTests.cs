using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class FormatHandlerTests
    {
        [TestMethod]
        public void DateFormatInfo_ExistingCulture_ReturnCorrectCulture()
        {
            string culture = "smn";
            DateCultureFormat formatHandler = new DateCultureFormat();
            DateTimeFormatInfo expectedResult = CultureInfo.CreateSpecificCulture(culture).DateTimeFormat;


            var result = formatHandler.DateFormatInfo(culture);

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }
        [TestMethod]
        public void DateFormatInfo_NotExistingCulture_ReturnCurrentCulture()
        {
            string culture = "aaaaaaa";
            DateCultureFormat formatHandler = new DateCultureFormat();
            DateTimeFormatInfo expectedResult = CultureInfo.CurrentCulture.DateTimeFormat;


            var result = formatHandler.DateFormatInfo(culture);

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }
    }
}
