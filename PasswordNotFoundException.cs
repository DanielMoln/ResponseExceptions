namespace exceptions
{
    public class PasswordNotFoundException : Exception
    {
        public int statusCode = ExceptionStatusCodes.PASSWORD_NOT_FOUND;

        public PasswordNotFoundException()
        {

        }
    }
}
