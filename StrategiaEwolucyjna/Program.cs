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
            Population populacja = new Population(5, 3, n => n * n, new Random());
            int i = 0;
            foreach (var x in populacja.Individuals)
            {
                
                Console.WriteLine("{0} {1} {2}-{3}","Osobnik", i,"posiada współczynnik porzeżycia" ,x.Fitness);
                i++;
                //Crossover(x.Chromosome, x.Chromosome);
                //x.Chromosome.Genes.Count();
            }
            for (int j = 0; j <= 50; j++)
            {
                //crossover
            }
            
            
        }
    }
}
