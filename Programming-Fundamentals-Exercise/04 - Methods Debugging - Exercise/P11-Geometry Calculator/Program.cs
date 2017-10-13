using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double width;
            double height;
            double side;
            double radius;

            switch (figureType)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Triangle(side,height);                    
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Square(side);
                    break;
                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Rectangle(width,height);
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    Circle(radius);
                    break;
            }

        }

        private static void Triangle(double side, double height)
        {
            double result = side * height / 2;
            Console.WriteLine($"{result:F2}");
        }

        private static void Square(double side)
        {
            double result = Math.Pow(side, 2);
            Console.WriteLine($"{result:F2}");
        }

        private static void Rectangle(double width, double height)
        {
            double result = width * height;
            Console.WriteLine($"{result:F2}");
        }

        private static void Circle(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{result:F2}");
        }


    }
}
