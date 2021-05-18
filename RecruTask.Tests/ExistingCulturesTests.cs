using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace RecruTask.Tests
{
    [TestClass]
    public class ExistingCulturesTests
    {
        [TestMethod]
        public void CheckIfCultureExists_ExistingCulture_ReturnTrue()
        {
            ExistingCultures existingCultures = new ExistingCultures();
            var expectedValue = true;
            string culture = "en-US";

            var result = existingCultures.CheckIfCultureExists(culture);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
