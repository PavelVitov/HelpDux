using System;

namespace DataLayer.Models.Exceptions
{
    public class OutOfBoundariesException : ApplicationException
    {
        public OutOfBoundariesException() 
        { 
        
        }
        public OutOfBoundariesException(string message) 
            : base(message) 
        {
        
        }
        public OutOfBoundariesException(string message, Exception innerException) 
            : base(message, innerException) 
        {
        
        }
    }
}
