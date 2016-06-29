using StrategiaEwolucyjna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            Population populacja = new Population(5, 3, n => n+n, new Random());
        }
    }
}
