using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit1._1.Sorts
{
    class UsporediPoPrezimenu : IComparer<Student>
    {
        public int Compare(Student x, Student y) => x.Prezime.CompareTo(y.Prezime);
    }
}
