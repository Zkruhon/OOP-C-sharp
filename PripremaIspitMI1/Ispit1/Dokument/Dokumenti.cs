using Ispit1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1.Dokument
{
    public class Dokumenti : ISignable
    {
        private bool isSigned;
        public string Naziv { get; set; }
        public string Tekst { get; set; }

        public void Sign() => isSigned = true;

        public override string ToString() => $"Naziv: {Naziv} Tekst: {Tekst} Potvrden { (isSigned ? "Da" : "Ne") }";
    }
}
