namespace FrankBot_API.Exceptions
{
    public class NullException: Exception
    {
        public NullException()
        {

        }
        public NullException(string message) : base(message)
        {

        }
    }
}
