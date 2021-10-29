using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Models
{
    public class Person
    {
        private const char DELIMITER = '|';
        public string Oib { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"{Oib}, {FirstName} {LastName}, {Phone}, {Email}";

        internal string FormatForFileLine() => $"{Oib}{DELIMITER}{FirstName}{DELIMITER}{LastName}{DELIMITER}{Phone}{DELIMITER}{Email}";

        internal static Person ParseFromFileLine(string line)
        {
            string[] details = line.Split(DELIMITER);
            return new Person
            {
                Oib = details[0],
                FirstName = details.Length > 1 ? details[1] : string.Empty,
                LastName = details.Length > 2 ? details[2] : string.Empty,
                Phone = details.Length > 3 ? details[3] : string.Empty,
                Email = details.Length > 4 ? details[4] : string.Empty,
            };
        }

        internal bool HasValidOib() => Oib.Length == 11 && Oib.All(char.IsDigit);
    }
}
