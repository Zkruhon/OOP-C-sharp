using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit1._1.Dokumenti;
using Ispit1._1.Interfaces;
using Ispit1._1.Model;
using Ispit1._1.Osobe;
using Ispit1._1.Sorts;

namespace Ispit1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(Student.Tipovi.Redovni, "Pranko", "Fapic");
            Student student2 = new Student(Student.Tipovi.Redovni, "Zruno", "Bajec");
            Student student3 = new Student(Student.Tipovi.Izvanredni, "Batrik", "Padanjak");

            List<Student> students = new List<Student>
            {
                student1,
                student3,
                student2
            };
            students.ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------------------------");

            students.Sort();
            students.ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------------------------");

            students.Sort(new UsporediPoPrezimenu());
            students.ForEach(Console.WriteLine);
            Console.WriteLine("---------------------------------------------");

            Kolegij kolegij = new Kolegij("123", "OOP", 20);
            Console.WriteLine(kolegij);
            Console.WriteLine("---------------------------------------------");

            Predavaci profesor = new Predavaci("Daniel", "Kučak", kolegij);
            Predavaci asistent = new Predavaci("Daniel", "Bele", kolegij);

            Console.WriteLine(profesor);
            Console.WriteLine(asistent);
            Console.WriteLine("---------------------------------------------");

            Dekan dekan = new Dekan("Bislav", "Malković", "diplomirani znalac");

            Console.WriteLine(dekan);
            Console.WriteLine("---------------------------------------------");

            List<Osoba> osobes = new List<Osoba>
            {
                student1,
                student2,
                student3,
                profesor,
                asistent,
                dekan
            };

            Console.WriteLine($"Osobe u memoriji: {osobes.Count}");
            Console.WriteLine("---------------------------------------------");

            Dokument dokument = new Dokument("Ispit", "BrunoJeGej", false);

            Console.WriteLine(dokument);
            Console.WriteLine("---------------------------------------------");

            List<ISignable> signables = new List<ISignable>
            {
                kolegij,
                dokument
            };

            signables.ForEach(dekan.Sign);
            signables.ForEach(Console.WriteLine);

        }
    }
}
