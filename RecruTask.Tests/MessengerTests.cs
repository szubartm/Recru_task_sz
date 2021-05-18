using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RecruTask.Tests
{
    [TestClass]
    public class MessengerTests
    {
       

        [TestMethod]
        public void MessageIncorrectFirstDateFormat_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Changing format to Your current culture format";

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
        public void MessageBeginning_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Do you want to see all acceptable cultures (type yes), or do you want to use your current culture (type anything)?";

            var result = messenger.MessageBeginning();

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageTypeFormatShortcut_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Please, enter a culture shortcut, or type 'default' to use current culture:";

            var result = messenger.MessageTypeFormatShortcut();

            Assert.AreEqual(result, wantedMessage);
        }

        [TestMethod]
        public void MessageEnterDate_ReturnMessage()
        {
            Messenger messenger = new Messenger();
            string wantedMessage = "Enter a date: ";

            var result = messenger.MessageEnterDate();

            Assert.AreEqual(result, wantedMessage);
        }




    }
}
