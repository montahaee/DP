using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.components
{
    internal class GPSNavigator
    {
        private string _route;

        public GPSNavigator () : this ("22lb, Baker Street, London to Scotland Yard, 8-10 Broadway, London") //TODO write default navigator
        {
        }

        public GPSNavigator (string route)
        {
            _route = route;
        }

        public string route { get => _route; }
    }
}
