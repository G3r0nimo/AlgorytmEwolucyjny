using StrategiaEwolucyjna.model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna.crossover
{
    public class OnePointCrossover : ICrossoverOperator  
    {
        private readonly Random _random;
        public List<Individual> IndividualsLambda { get; set; }

        public OnePointCrossover(Random random)
        {
            _random = random;
            IndividualsLambda = new List<Individual>();
        }
 

        public void Crossover(Individual parent1, Individual parent2)
        {
            Individual children1=parent1;

            int k = _random.Next(0,1);
        
            for (int i = 0; i < parent2.Chromosome.Genes.Count; i++)
            {
                children1.Chromosome.Genes[i] = parent1.Chromosome.Genes[i] * k + (1 - k) * parent2.Chromosome.Genes[i];             
                Count.CalculateFitnes(children1);
            }
            \
            IndividualsLambda.Add(new Individual (children1));
       
            
        }


    }
    
}
