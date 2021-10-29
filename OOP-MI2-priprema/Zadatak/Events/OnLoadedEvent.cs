using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Models;

namespace Zadatak.Events
{
    public class OnLadedEventArgs : EventArgs
    {
        public Person LoadedPerson { get; set; }
        public IList<string> MissingData { get; set; }
    }

    public delegate void OnLoadedEventHandler(object sender, OnLadedEventArgs args);
}
