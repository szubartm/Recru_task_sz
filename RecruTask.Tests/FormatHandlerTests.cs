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
            FormatHandler formatHandler = new FormatHandler();
            DateTimeFormatInfo expectedResult = CultureInfo.CreateSpecificCulture(culture).DateTimeFormat;


            var result = formatHandler.DateFormatInfo(culture);

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }
        [TestMethod]
        public void DateFormatInfo_NotExistingCulture_ReturnCurrentCulture()
        {
            string culture = "aaaaaaa";
            FormatHandler formatHandler = new FormatHandler();
            DateTimeFormatInfo expectedResult = CultureInfo.CurrentCulture.DateTimeFormat;


            var result = formatHandler.DateFormatInfo(culture);

            Assert.AreEqual(expectedResult.ToString(), result.ToString());
        }
    }
}
