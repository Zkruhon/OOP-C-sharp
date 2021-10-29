using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1.Osobe
{
    public class Student : Osoba, IComparable<Student>
    {
        public static int idGenerator;
        private readonly int id;
        public enum StudentType
        {
            Redovni = 1,
            Vanredni
        }
        
        public StudentType Tip { get; set; }

        public Student(string Ime, string Prezime, StudentType type) : base (Ime, Prezime)
        {
            id = ++idGenerator;
            Tip = type;
        }

        public override string ToString() => $"ID: {id}\n{base.ToString()}\nTip: {Tip}";

        public int CompareTo(Student other) => -id.CompareTo(other.id); // int u sebi ima predodredeno za komparanje pa nije this

        public override bool Equals(object obj) => obj is Student other ? id == other.id : false; // ako je obj student usporedi ideve

        public override int GetHashCode() => id.GetHashCode(); // 
    }
}
