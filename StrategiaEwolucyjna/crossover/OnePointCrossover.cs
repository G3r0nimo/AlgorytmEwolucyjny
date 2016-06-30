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
        public List<Chromosome> IndividualsLambda { get; set; }

        public OnePointCrossover(Random random)
        {
            _random = random;
        }

        public void Crossover(Chromosome parent1, Chromosome parent2)
        {
            Chromosome children1 = parent1;
            Chromosome children2 = parent2;


            int tmp = _random.Next(1, parent2.Genes.Count - 1);
            //Console.WriteLine($"Random = {tmp}");

            for (int i = tmp; i < parent2.Genes.Count; i++)
            {
                //Console.WriteLine($"{parent1.Genes[i]} na {parent2.Genes[i]}");
                //bool buffer = parent1.Genes[i];
                children1.Genes[i] = parent2.Genes[i];
                children2.Genes[i] = parent1.Genes[i];
                children1.Fenotype = 0;
                children2.Fenotype = 0;
            }
            //List<Chromosome> return2 = return2.Add(children1);
            IndividualsLambda.Add(children1);
            IndividualsLambda.Add(children2);


        }
        

    }
    
}
