﻿namespace exceptions
{
    public class BadOldPasswordException : Exception
    {
        public int statusCode = ExceptionStatusCodes.BAD_OLD_PASSWORD;
        public BadOldPasswordException()
        {

        }
    }
}
