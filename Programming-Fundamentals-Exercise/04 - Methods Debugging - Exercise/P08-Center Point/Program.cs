using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double hypotenuseOne = GetHypotenuseOne(x1, y1);
            double hypotenuseTwo = GetHypotenusTwo(x2, y2);

            if (hypotenuseOne > hypotenuseTwo)
            {
                Console.WriteLine($"({x2}, {y2})");

            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }


        }

        static double GetHypotenusTwo(double x2, double y2)
        {
            double hypotenuseOne = Math.Sqrt(x2 * x2 + y2 * y2);
            return hypotenuseOne;
        }


        static double GetHypotenuseOne(double x1, double y1)
        {
            double hypotenuseOne = Math.Sqrt(x1 * x1 + y1 * y1);
            return hypotenuseOne;
        }
    }
}
