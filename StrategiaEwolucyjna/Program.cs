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


        }
        static void Main(string[] args)
        {
            Population populacja = new Population(5, 6, n => n * n, new Random());
            int ilosc = 5;//ilosc pokoleń
            for (int i = 0; i < ilosc; i++)
            {

                for (int j = 0; j <= 2; i++)
                {
                    foreach (var z in populacja.Individuals)
                    {
                        foreach (var x in populacja.Individuals)
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
                    populacja.Individuals.Add(y);
                }
                var top = populacja.Individuals.OrderByDescending(x => x.Fitness).Take(5);
                populacja = null;
                populacja.Individuals.Add(top);
                
            }
            
        }

        
    }
}
