using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Exceptions
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

