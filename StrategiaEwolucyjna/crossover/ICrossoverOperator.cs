using StrategiaEwolucyjna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna.crossover
{
    public interface ICrossoverOperator
    {
        void Crossover(Individual parent1, Individual parent2);
    }
}
