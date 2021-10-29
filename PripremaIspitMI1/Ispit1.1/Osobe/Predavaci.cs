using Ispit1._1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Osobe
{
    class Predavaci : Osoba
    {
        public Predavaci(string ime, string prezime, Kolegij kolegij) : base(ime, prezime)
        {
            Kolegij = kolegij;
        }

        public Kolegij Kolegij { get; set; }

        public override string ToString() => $"{base.ToString()}, Kolegij: {Kolegij.Naziv}";
    }
}
