using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
