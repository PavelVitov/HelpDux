using System;

namespace DataLayer.Models.Exceptions
{
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(string message)
            : base(message)
        {

        }

        public EntityNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public EntityNotFoundException()
            : base()
        {

        }

    }
}
