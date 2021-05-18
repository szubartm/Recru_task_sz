namespace RecruTask
{
    public class Messenger
    {
        string message;
        
        

        public string MessageIncorrectDateFormat()
        {
            return message = "Changing format to default (dd/mm/yyyy)";
        }



        public string MessageIncorrectValue()
        {
            return message = "You have entered an incorrect value.";
        }

       

        public string MessageBeginning()
        {
            return message = "Do you want to see all acceptable cultures (type yes), or do you want to use your current culture (type anything)?";
        }

        public string MessageTypeFormatShortcut()
        {
            return message = "Please, enter a culture shortcut, or type 'default' to use current culture:";
        }

        public string MessageEnterDate()
        {
            return message = "Enter a date: ";
        }
      
    }
}
