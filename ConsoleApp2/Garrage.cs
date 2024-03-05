using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Garrage
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public void AddVihicle(Vehicle v)
        {
            vehicles.Add(v);
        }
    }
}
