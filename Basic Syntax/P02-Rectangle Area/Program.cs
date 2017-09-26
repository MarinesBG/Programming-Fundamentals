using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumb = double.Parse(Console.ReadLine());
            var secondNumb = double.Parse(Console.ReadLine());

            double result = firstNumb * secondNumb;

            Console.WriteLine($"{result:F2}");

        }
    }
}
