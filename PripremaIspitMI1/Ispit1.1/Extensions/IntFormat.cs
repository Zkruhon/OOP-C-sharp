using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Extensions
{
    public static class IntFormat
    {
        public static string IntToFormat(this int value, string format) => $"{value}{format}";
    }
}
