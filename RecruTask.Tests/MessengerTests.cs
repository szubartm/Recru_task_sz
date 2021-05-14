using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RecruTask.Tests
{
    [TestClass]
    public class MessengerTests
    {
        [TestMethod]
        public void MessageForUSFormat_IfTrue_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Input Date format set to US";

            var result = messenger.MessageForUSFormat(true);

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageForUSFormat_IfFalse_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Input Date format set to default";

            var result = messenger.MessageForUSFormat(false);

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageIncorrectFirstDateFormat_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Incorrect date format. Changing format to default (dd/mm/yyyy)";

            var result = messenger.MessageIncorrectDateFormat();

            Assert.AreEqual(result, wantedMessage);
        }

        

        [TestMethod]
        public void MessageIncorrectValue_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "You have entered an incorrect value.";

            var result = messenger.MessageIncorrectValue();

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageTheSameValue_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "You have entered the same dates. Printing just one.";

            var result = messenger.MessageTheSameValue();

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageForUSFormat_UserTypedYes_ReturnMessage()
        {
            var message = new Messenger();

            var result = message.MessageForUSFormat(true);
            var wantedResult = "Input Date format set to US";

            Assert.AreEqual(result, wantedResult);

        }

        [TestMethod]
        public void MessageForUSFormat_UserTypedNo_ReturnMessage()
        {
            var message = new Messenger();

            var result = message.MessageForUSFormat(false);
            var wantedResult = "Input Date format set to default";

            Assert.AreEqual(result, wantedResult);

        }
    }
}
