using System;

namespace VendingMachine.Project.Exceptions
{
    public class BandIsEmptyException : Exception
    {
        public BandIsEmptyException(string operationType) : base(operationType) { }
    }
}
