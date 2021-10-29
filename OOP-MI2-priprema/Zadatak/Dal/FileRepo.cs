using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Models;

namespace Zadatak.Dal
{
    class FileRepo : IRepo
    {
        private const string DIR = @"C:\Users\zvoni\Desktop\data";
        private const string PATH = DIR + @"\people.txt";

        public FileRepo() => CreateFileIfNotExists();

        private void CreateFileIfNotExists()
        {
            Directory.CreateDirectory(DIR);
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public IList<Person> LoadPeople()
        {
            IList<Person> people = new List<Person>();
            string[] lines = File.ReadAllLines(PATH);
            //foreach (var line in lines)
            //{
            //    people.Add(Person.ParseFromFileLine(line));
            //}
            lines.ToList().ForEach(line => people.Add(Person.ParseFromFileLine(line)));
            return people;
        }

        public void SavePeople(IList<Person> people) => File.WriteAllLines(PATH, people.Select(p => p.FormatForFileLine()));
        //{
        //    string[] lines = new string[people.Count];
        //    int index = 0;
        //    foreach (var p in people)
        //    {
        //        lines[index++] = p.FormatForFileLine();
        //    }
        //    File.WriteAllLines(PATH, lines);
        //}
    }
}
