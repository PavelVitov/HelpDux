using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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