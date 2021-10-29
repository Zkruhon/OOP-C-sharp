using Ispit1.Osobe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1.Sort
{
    internal class SortStudentByPrezime : IComparer<Student> // INTERNAL!!!
    {
        public int Compare(Student x, Student y) => x.Prezime.CompareTo(y.Prezime);
    }
}
