namespace exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public int statusCode = ExceptionStatusCodes.USER_ALREADY_EXISTS;

        public UserAlreadyExistsException()
        {

        }
    }
}
