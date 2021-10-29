using System;
using System.Runtime.Serialization;

namespace Ispit1.Exceptions
{
    [Serializable]
    internal class ECTSOutOfBoundException : Exception
    {
        public ECTSOutOfBoundException() : base("ECTS bodovi moraju biti između 20 i 30;")
        {
        }

        public ECTSOutOfBoundException(string message) : base(message)
        {
        }
    }
}