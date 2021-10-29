using Ispit1._1.Osobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1
{
    class Student : Osoba, IComparable<Student>
    {
        private static int idGenerator;
        private readonly int id;
        public Student(Tipovi tip, string ime, string prezime) : base(ime, prezime)
        {
            id = ++idGenerator;
            Tip = tip;
        }

        public int ID { get; set; }
        public Tipovi Tip { get; set; }
        public enum Tipovi
        {
            Izvanredni = 1,
            Redovni
        }

        public override string ToString() => $"ID: {id}\n{base.ToString()}\nTip: {Tip}";

        public int CompareTo(Student other) => id.CompareTo(other.id);

        public override bool Equals(object obj) => obj is Student other ? id == other.id : false;

        public override int GetHashCode() => id.GetHashCode();
    }
}
