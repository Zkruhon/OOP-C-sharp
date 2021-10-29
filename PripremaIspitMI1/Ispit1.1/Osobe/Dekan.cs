using Ispit1._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Osobe
{
    public class Dekan : Osoba
    {
        public Dekan(string ime, string prezime, string titula) : base(ime, prezime)
        {
            Titula = titula;
        }

        public string Titula { get; set; }

        public void Sign(ISignable signable) => signable.Sign();

        public override string ToString() => $"{base.ToString()}, Titula: {Titula}";
    }
}
