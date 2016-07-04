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
        static void Main(string[] args)
        {

            Population populacja = new Population(5, 6, n => n * n, new Random());
            
            
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

                populacja.Individuals.Add(item);
            }
            var top = populacja.Individuals.OrderByDescending(populacja => populacja.Fitness).Take(5);

        }
    }
}
