using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1.Osobe
{
    class Profesori : Osoba
    {
        public Profesori(string Ime, string Prezime, Kolegij kolegij) : base(Ime, Prezime)
        {
            Kolegij = kolegij;
        }
        public Kolegij Kolegij { get; set; }

        public override string ToString() => $"{base.ToString()} Kolegij: {Kolegij.Naziv}";
    }
}
