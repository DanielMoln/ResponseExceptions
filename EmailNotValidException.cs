namespace exceptions
{
    public class EmailNotValidException : Exception
    {
        public int statusCode = ExceptionStatusCodes.EMAIL_NOT_VALID;

        public EmailNotValidException()
        {  }
    }
}
