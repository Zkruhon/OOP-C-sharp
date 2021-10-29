using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Dal;
using Zadatak.Events;

namespace Zadatak.Models
{
    class PersonManager
    {
        public event OnLoadedEventHandler OnLoaded;
        public event OnExceptionEventHandler OnException;

        private readonly IRepo repo;

        private IDictionary<string, Person> peopleDictionary;

        public PersonManager() => repo = new FileRepo();
        public IDictionary<string, Person> PeopleDictionary {
            get
            {
                if (peopleDictionary == null)
                {
                    Load();
                }
                return new Dictionary<string, Person>(peopleDictionary);
            }
        }

        private void Load()
        {
            try
            {
                IList<Person> people = repo.LoadPeople();
                FillDictionary(people);
            } catch (Exception e)
            {
                OnException?.Invoke(this, new OnExceptionEventArgs { Exception = e });
            }
        }

        private void FillDictionary(IList<Person> people)
        {
            peopleDictionary = new Dictionary<string, Person>();
            people.ToList().ForEach(p =>
            {
                try
                {
                    if (p.HasValidOib())
                    {                        
                        peopleDictionary.Add(p.Oib, p);

                        IList<string> missingData = FillMissingData(p);

                        OnLoaded?.Invoke(this, new OnLadedEventArgs
                        {
                            LoadedPerson = p,
                            MissingData = missingData
                        });
                    }
                    else
                    {
                        //throw new Exceptions.InvalidOibException();
                        throw new InvalidOibException($"{p.Oib} - oib is not valid");
                    }

                }
                catch (Exception e)
                {
                    OnException?.Invoke(this, new OnExceptionEventArgs { Exception = e });
                }
            });
        }

        private static IList<string> FillMissingData(Person p)
        {
            IList<string> missingData = new List<string>();
            if (string.IsNullOrEmpty(p.FirstName))
            {
                missingData.Add(nameof(Person.FirstName));
            }
            if (string.IsNullOrEmpty(p.LastName))
            {
                missingData.Add(nameof(Person.LastName));
            }
            if (string.IsNullOrEmpty(p.Phone))
            {
                missingData.Add(nameof(Person.Phone));
            }
            if (string.IsNullOrEmpty(p.Email))
            {
                missingData.Add(nameof(Person.Email));
            }

            return missingData;
        }

        public void Save(IList<Person> people)
        {
            try
            {
                repo.SavePeople(people);
            }
            catch (Exception e)
            {
                OnException?.Invoke(this, new OnExceptionEventArgs { Exception = e });
            }
        }
    }
}
