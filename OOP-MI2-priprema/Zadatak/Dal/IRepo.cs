using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Models;

namespace Zadatak.Dal
{
    public interface IRepo
    {
        void SavePeople(IList<Person> people);
        IList<Person> LoadPeople();
    }
}
