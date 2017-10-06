using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().
                Split(' ').Select(double.Parse).ToArray();


            foreach (double element in array)
            {
               
                double roundElement = Math.Round((double) element, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{element} => {roundElement}");
            }
            


        }
    }
}
