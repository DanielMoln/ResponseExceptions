using exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseExceptions
{
    public class HeaderSecurityTokenNotValidException : Exception
    {
        public int statusCode = ExceptionStatusCodes.HEADER_SECURITY_TOKEN_NOT_VALID;

        public HeaderSecurityTokenNotValidException()
        {

        }
    }
}
