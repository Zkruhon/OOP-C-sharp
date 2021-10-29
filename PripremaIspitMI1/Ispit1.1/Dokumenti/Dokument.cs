using Ispit1._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Dokumenti
{
    class Dokument : ISignable
    {
        private bool isSigned;

        public Dokument(string naziv, string tekst, bool IsSigned)
        {
            Naziv = naziv;
            Tekst = tekst;
            isSigned = IsSigned;
        }

        public string Naziv { get; set; }
        public string Tekst { get; set; }

        public void Sign() => isSigned = true;

        public override string ToString() => $"Naziv: {Naziv}, Tekst: {Tekst}, Potpisano: { (isSigned ? "Da" : "Ne") }";
    }
}
