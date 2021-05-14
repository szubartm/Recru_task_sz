namespace RecruTask
{
    public class Messenger
    {
        string message;
        public string MessageForUSFormat(bool result)
        {
            message = "Input Date format set to default";
            if (result)
            {
                message = "Input Date format set to US";
            }
            return message;

        }

        public string MessageIncorrectDateFormat()
        {
            return message = "Incorrect date format. Changing format to default (dd/mm/yyyy)";
        }



        public string MessageIncorrectValue()
        {
            return message = "You have entered an incorrect value.";
        }

        public string MessageTheSameValue()
        {
            return message = "You have entered the same dates. Printing just one.";
        }

        public string MessageSomethingWentWrong()
        {
            return message = "Something went wrong :(";
        }
    }
}
