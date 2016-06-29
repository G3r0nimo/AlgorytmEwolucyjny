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
        void Crossover(Chromosome parent1, Chromosome parent2);
    }
}
