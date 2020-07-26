using System;
using System.Collections.Generic;
using System.Text;

namespace S11_aula146_exeExceptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string msg) : base(msg) { }
    }
}
