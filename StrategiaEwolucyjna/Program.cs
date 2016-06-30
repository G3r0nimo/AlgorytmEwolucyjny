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
            
            for (int i = 0; i <= 2; i++)
            {
                foreach (var z in populacja.Individuals)
                {
                    foreach (var x in populacja.Individuals)
                    {
                        var crossoverOperator = new OnePointCrossover(new Random());
                        crossoverOperator.Crossover(z.Chromosome, x.Chromosome);
                        //wynik do listy IndividualsLambda
                         ///
                    }

                }
            }
            //lamda na top 5 os z lity zapętlenie pokolenia

        }
    }
}
