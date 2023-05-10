using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
