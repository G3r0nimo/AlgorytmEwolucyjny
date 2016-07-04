using StrategiaEwolucyjna.model;
using StrategiaEwolucyjna.crossover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna
{
    class Program
    {
        public List<Individual> populacja { get; set; }

        public void Generationv2(Population fresh)
        {

            for (int i = 0; i <= 2; i++)
            {
                foreach (var z in fresh.Individuals)
                {
                    foreach (var x in fresh.Individuals)
                    {
                        var crossoverOperator = new OnePointCrossover(new Random());
                        crossoverOperator.Crossover(z, x);
                    }
                }
            }
            var lambda = new OnePointCrossover(new Random());
            var pokolenie = lambda.IndividualsLambda;

            foreach (var y in pokolenie)
            {
                fresh.Individuals.Add(y);
            }
            var top = fresh.Individuals.OrderByDescending(x => x.Fitness).Take(5).ToList();
            populacja.Clear();
            populacja = top;

        }
        static void Main(string[] args)
        {
            Population populacja = new Population(5, 6, n => n * n, new Random());
            Generationv2(populacja);
        }

        
    }
}
