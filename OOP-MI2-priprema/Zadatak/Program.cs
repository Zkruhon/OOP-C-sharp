using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Models;

namespace Zadatak
{
    class Program
    {
        private const string DELIMITER = ",";

        static void Main(string[] args)
        {
            try
            {
                PersonManager personManager = new PersonManager();
                personManager.OnException += PersonManager_OnException;
                personManager.OnLoaded += PersonManager_OnLoaded;

                SavePersons(personManager);

                IDictionary<string, Person> people =  personManager.PeopleDictionary;

                ShowMessage("\nUploaded records\n", ConsoleColor.White);
                people.ToList().ForEach(kv => ShowMessage($"{kv.Value}", ConsoleColor.Yellow));

            } catch (Exception e)
            {
                ShowMessage(e.Message, ConsoleColor.Red);
            }
        }


        private static void PersonManager_OnException(object sender, Events.OnExceptionEventArgs args) => ShowMessage(args.Exception.Message, ConsoleColor.Red);

        private static void PersonManager_OnLoaded(object sender, Events.OnLadedEventArgs args)
        {
            if (args.MissingData.Count == 0)
            {
                ShowMessage(args.LoadedPerson.ToString(), ConsoleColor.Green);
            } 
            else
            {
                string report = string.Join(DELIMITER, args.MissingData);
                ShowMessage(report, ConsoleColor.Blue);
            }
        }


        private static void ShowMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // this is just for testing - not neeeded for the project!
        private static void SavePersons(PersonManager personManager)
        {
            IList<Person> people = new List<Person>
            {
                new Person { Oib = "01234567891", FirstName = "Daniel", LastName = "Bele", Email = "dnlbele@gmail.com", Phone = "01121221"},
                new Person { Oib = "0891123456", FirstName = "Milica", LastName = "Krmpotic", Email = "mk@gmail.com", Phone = "12122101"},
                new Person { Oib = "56789101234", FirstName = "Gojko", LastName = "Mrnjavcevic", Email = "gm@gmail.com", Phone = "12120121"},
                new Person { Oib = "101256789X4", FirstName = "", LastName = "Mrnjavcevic", Email = "gm@gmail.com", Phone = "12120121"},
                new Person { Oib = "23456789101", FirstName = "", LastName = "", Email = "", Phone = "12120121"},
                new Person { Oib = "01234567891", FirstName = "", LastName = "", Email = "", Phone = ""}
            };
            personManager.Save(people);
        }
    }
}
