namespace exceptions
{
    public class PasswordNotMatchException : Exception
    {
        public int statusCode = ExceptionStatusCodes.PASSWORD_NOT_MATCH;
        public PasswordNotMatchException()
        {

        }
    }
}
