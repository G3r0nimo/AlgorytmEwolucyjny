﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiaEwolucyjna.model
{
    public class Chromosome
    {
        public List<double> Genes { get; set; }

        public double Fenotype
        {
            set { }
            get
            {
                return CalculateFenotype();
            }
        }

        public Chromosome(int chromosomeLength, Random random)
        {
            //Genes = Enumerable.Range(0, chromosomeLength)
            //    .Select(x => random.NextDouble() <= 0.5)
            //    .ToList();
            for (int i = 0; i <chromosomeLength ; i++)
            {
                Genes[i] = random.Next(3);
            }
       
        }


        private double CalculateFenotype()
        {
            double wynik = 0;

            for (int i = Genes.Count-1, j = 0; i >= 0; i--, j++)
            {
                wynik += Convert.ToDouble(Genes[i]) * Math.Pow(2, j);
            }
            Console.WriteLine($"x: {wynik}");

            return wynik;
        }

    }


    public static class Count
    {

        public static double CalculateFitnes(Individual os)
        {
            double wynik = 0.0;

            for (int i = os.Chromosome.Genes.Count - 1, j = 0; i >= 0; i--, j++)
            {
                wynik += Convert.ToDouble(os.Chromosome.Genes[i]) * Math.Pow(2, j);
            }
           // Console.WriteLine($"x: {wynik}");

            return wynik;
        }
    }
}
