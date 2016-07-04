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
        public List<Population> populacja { get; set; }

        static void Main(string[] args)
        {

            populacja = new Population(5, 6, n => n * n, new Random());
            
            
        }

        public void Generation(Population fresh)
        {

            for (int i = 0; i <= 2; i++)
            {
                foreach (var z in fresh.Individuals)
                {
                    foreach (var x in fresh.Individuals)
                    {
                        var crossoverOperator = new OnePointCrossover(new Random());
                        crossoverOperator.Crossover(z, x);
                        //wynik do listy IndividualsLambda
                    }
                }
            }
            var lambda = new OnePointCrossover(new Random());
            var pokolenie = lambda.IndividualsLambda;

            foreach (var item in pokolenie)
            {

                fresh.Individuals.Add(item);
            }
            var top = fresh.Individuals.OrderByDescending(x => x.Fitness).Take(5);

        }
    }
}
