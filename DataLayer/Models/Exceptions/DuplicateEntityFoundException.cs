using System;

namespace DataLayer.Models.Exceptions
{

    public class DuplicateEntityFoundException : ApplicationException
    {
        public DuplicateEntityFoundException()
            : base()
        {

        }

        public DuplicateEntityFoundException(string message)
            : base(message)
        {

        }

        public DuplicateEntityFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

    }


}