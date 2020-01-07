using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Bank_Exception.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
