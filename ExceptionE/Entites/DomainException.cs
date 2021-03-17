using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionE.Entites
{
    class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message) { }
    }
}
