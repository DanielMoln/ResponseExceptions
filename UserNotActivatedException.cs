namespace exceptions
{
    public class UserNotActivatedException : Exception
    {
        public int statusCode = ExceptionStatusCodes.USER_NOT_ACTIVATED;

        public UserNotActivatedException()
        {

        }
    }
}
