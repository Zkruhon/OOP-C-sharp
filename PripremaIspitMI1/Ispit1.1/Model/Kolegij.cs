using Ispit1._1.Exceptions;
using Ispit1._1.Extensions;
using Ispit1._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Model
{
    public class Kolegij : ISignable
    {
        private bool isSigned;
        private int ects;

        public Kolegij(string sifra, string naziv, int ects)
        {
            Sifra = sifra;
            Naziv = naziv;
            ECTS = ects;
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public int ECTS
        { 
            get => ects;
            set
            {
                if (value <= 30 || value >= 20)
                {
                    ects = value;
                }
                else
                {
                    throw new ECTSOutOfBoundsException();
                }
            }
        }

        public void Sign() => isSigned = true;

        public override string ToString() => $"Sifra: {Sifra}, Naziv: {Naziv}, Broj ECTS-a: {ECTS.IntToFormat("ects")}, Potvrđen: { (isSigned ? "Da" : "Ne") }";
    }
}
