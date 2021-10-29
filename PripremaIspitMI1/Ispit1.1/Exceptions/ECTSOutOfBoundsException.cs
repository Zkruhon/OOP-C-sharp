using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Exceptions
{
    class ECTSOutOfBoundsException : Exception
    {
        public ECTSOutOfBoundsException() : base("ECTS out of bounds.")
        {
        }

        public ECTSOutOfBoundsException(string message) : base(message)
        {
        }
    }
}
