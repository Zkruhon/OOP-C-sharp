using Ispit1.Dokument;
using Ispit1.Interfaces;
using Ispit1.Osobe;
using Ispit1.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentPero = new Student("Pero", "Peric", Student.StudentType.Redovni);
            Student studentLuka = new Student("Luka", "Lukic", Student.StudentType.Redovni);
            Student studentMaja = new Student("Maja", "Majic", Student.StudentType.Redovni);

            List<Student> students = new List<Student>
            {
                studentLuka,
                studentPero,
                studentMaja
            };
            students.ForEach(Console.WriteLine);

            students.Sort();
            Console.WriteLine("--------------------------------------");
            students.ForEach(Console.WriteLine);

            students.Sort(new SortStudentByPrezime()); // ne zaboravit instancirat jer je objekt, sa new
            Console.WriteLine("--------------------------------------");
            students.ForEach(Console.WriteLine);

            Kolegij kolegij = new Kolegij("123", "OOP", 20);
            Console.WriteLine(kolegij);

            Profesori asistent = new Profesori("Daniel", "Bele", kolegij);
            Profesori predavac = new Profesori("Daniel", "Kučak", kolegij);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(asistent);
            Console.WriteLine(predavac);

            Console.WriteLine("--------------------------------------");
            Dekan dekan = new Dekan("Mislav", "Balković", "mr. sc.");
            Console.WriteLine(dekan);

            List<Osoba> osobe = new List<Osoba>
            {
                studentLuka,
                studentPero,
                studentMaja,
                asistent,
                predavac,
                dekan
            };


            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Osobe: {osobe.Count}");

            Console.WriteLine("--------------------------------------");
            Dokumenti dokument = new Dokumenti
            {
                Naziv = "Sample.txt",
                Tekst = "Foo"
            };

            List<ISignable> signables = new List<ISignable>
            {
                kolegij,
                dokument
            };

            signables.ForEach(dekan.Sign); // sign je metoda pa nema bracketse

            signables.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------------------------");
        }
    }
}
