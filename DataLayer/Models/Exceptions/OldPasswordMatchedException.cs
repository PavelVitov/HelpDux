using System;

namespace DataLayer.Models.Exceptions
{
    public class OldPasswordMatchedException : ApplicationException
    {
        public OldPasswordMatchedException()
            : base("New password cannot match old password.")
        {

        }

        public OldPasswordMatchedException(string message)
            : base(message)
        {

        }

        public OldPasswordMatchedException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
