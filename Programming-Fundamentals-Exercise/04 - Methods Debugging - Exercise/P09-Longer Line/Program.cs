using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double SecondLine = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (firstLine > SecondLine)
            {
                double hypotenuseOne = GetHypotenuseOne(x1, y1);
                double hypotenuseTwo = GetHypotenusTwo(x2, y2);

                if (hypotenuseOne > hypotenuseTwo)
                {
                    Console.WriteLine($" ({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                double hypotenuseOne = GetHypotenuseOne(x3, y3);
                double hypotenuseTwo = GetHypotenusTwo(x4, y4);
                if (hypotenuseOne > hypotenuseTwo)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
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