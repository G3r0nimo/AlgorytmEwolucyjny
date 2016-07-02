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
        }

        public void Crossover(Individual parent1, Individual parent2)
        {
            Individual children1 = parent1;
            children1.Chromosome.Genes = parent1.Chromosome.Genes;
            Individual children2 = parent2;
            children2.Chromosome.Genes = parent2.Chromosome.Genes;


            int tmp = _random.Next(1, parent2.Chromosome.Genes.Count - 1);
         
            for (int i = tmp; i < parent2.Chromosome.Genes.Count; i++)
            {
                 children1.Chromosome.Genes[i] = parent2.Chromosome.Genes[i];
                children2.Chromosome.Genes[i] = parent1.Chromosome.Genes[i];
                Count.CalculateFitnes(children1);
                Count.CalculateFitnes(children2);
            }
            //List<Chromosome> return2 = return2.Add(children1);
            IndividualsLambda.Add(new Individual (children1));
           // IndividualsLambda.Add(children2);
            

    
            
        }


    }
    
}
