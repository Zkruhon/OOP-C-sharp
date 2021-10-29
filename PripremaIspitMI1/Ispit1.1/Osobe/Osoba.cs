using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Osobe
{
    public abstract class Osoba
    {
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString() => $"Ime: {Ime}\nPrezime: {Prezime}";
    }
}
