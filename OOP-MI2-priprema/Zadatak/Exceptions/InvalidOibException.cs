using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class InvalidOibException : Exception
    {
        public InvalidOibException() : base("Oib should be 11 digits")
        {
        }

        public InvalidOibException(string message) : base(message)
        {
        }
    }
}