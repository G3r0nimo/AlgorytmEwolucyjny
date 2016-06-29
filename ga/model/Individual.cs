using StrategiaEwolucyjna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna.model
{
    public class Individual
    {
        private Individual individual;

        public double Fitness { get; set; }
        public Chromosome Chromosome { get; set; }

        public Individual(int chromosomeLength, Random random)
        {
            Chromosome = new Chromosome(chromosomeLength, random);
        }

        public Individual(Individual individual)
        {
            Fitness = individual.Fitness;
            
        }
    }
}
