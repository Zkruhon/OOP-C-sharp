using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1.Extensions
{
    public static class Exstensions
    {
        public static string IntToFormat(this int value, string format) => $"{value} {format}";
    }
}
