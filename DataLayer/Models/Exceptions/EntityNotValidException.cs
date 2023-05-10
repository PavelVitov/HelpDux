using System;

namespace DataLayer.Models.Exceptions
{
    public class EntityNotValidException : ApplicationException
    {
        public EntityNotValidException()
        {

        }

        public EntityNotValidException(string message)
            : base(message)
        {

        }

        public EntityNotValidException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
