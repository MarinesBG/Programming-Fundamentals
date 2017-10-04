using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width,height);
            Console.WriteLine(area);
        }

        private static double CalculateTriangleArea(double width , double height)
        {
            return width * height / 2;  
        }
    }
}
