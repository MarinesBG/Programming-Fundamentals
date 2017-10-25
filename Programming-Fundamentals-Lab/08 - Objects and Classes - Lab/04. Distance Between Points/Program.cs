using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class Program 
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            Console.WriteLine($"{CalcDistance(p1,p2):f3}");
        }

        public static Point ReadPoint()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point p1 = new Point { X = first[0], Y = first[1] };
            return p1;
        }


        public static double CalcDistance(Point p1, Point p2)
        {
            double indexOne = (p1.X - p2.X) * (p1.X - p2.X);
            double indexTwo = (p1.Y - p2.Y) * (p1.Y - p2.Y);
            double distance = Math.Sqrt(indexOne + indexTwo);

            return distance;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
