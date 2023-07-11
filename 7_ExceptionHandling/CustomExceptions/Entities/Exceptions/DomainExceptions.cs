using System;

namespace CustomExceptions.Entities.Exceptions
{
    public class DomainExpection : ApplicationException
    {
        public DomainExpection(string message) : base(message)
        {}
    }
}