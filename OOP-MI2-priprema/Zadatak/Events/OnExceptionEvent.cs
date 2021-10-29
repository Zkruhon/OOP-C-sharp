using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Events
{
    public class OnExceptionEventArgs : EventArgs
    {
        public Exception Exception { get; set; }
    }
    public delegate void OnExceptionEventHandler(object sender, OnExceptionEventArgs args);
}
