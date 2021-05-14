using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RecruTask.Tests
{
    [TestClass]
    public class DateFormatCheckerTests
    {
     

        [TestMethod]
        public void CheckIfUSFormatFortDate_True_ReturnTrue()
        {
            string date1 = "12/31/2020";

            DateFormatChecker dateFormatChecker = new DateFormatChecker();

            var result = dateFormatChecker.CheckIfUSFormatForDate(date1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfUSFormatForDate_False_ReturnFalse()
        {
            string date1 = "31/12/2020";

            DateFormatChecker dateFormatChecker = new DateFormatChecker();

            var result = dateFormatChecker.CheckIfUSFormatForDate(date1);

            Assert.IsFalse(result);
        }

       
        [TestMethod]
        public void CheckIfCurrentFormatFortDate_True_ReturnTrue()
        {
            string date1 = "31/12/2020";

            DateFormatChecker dateFormatChecker = new DateFormatChecker();

            var result = dateFormatChecker.CheckIfCurrentFormatForDate(date1);

            Assert.IsTrue(result);
        }
    

    [TestMethod]
        public void CheckIfCurrentFormatForDate_False_ReturnFalse()
        {
            string date1 = "12.31.2020";

            DateFormatChecker dateFormatChecker = new DateFormatChecker();

            var result = dateFormatChecker.CheckIfCurrentFormatForDate(date1);

            Assert.IsFalse(result);
        }

       
        }
    }

