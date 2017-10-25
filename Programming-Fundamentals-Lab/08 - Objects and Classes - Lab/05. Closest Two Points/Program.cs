using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[] points = ReadPoints();
            Point[] closestPoint = FindClosestPoints(points);

            PrintDistance(closestPoint);

            PrintPoint(closestPoint[0]);
            PrintPoint(closestPoint[1]);

        }
        
        public static Point[] ReadPoints()
        {
            int input = int.Parse(Console.ReadLine());

            Point[] point = new Point[input];

            for (int i = 0; i < input; i++)
            {
               point[i] = ReadPoint();
            }

            return point;
        }

        public static Point ReadPoint()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point { X = array[0], Y = array[1] };
            return point;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double indexOne = (p1.X - p2.X) * (p1.X - p2.X);
            double indexTwo = (p1.Y - p2.Y) * (p1.Y - p2.Y);
            double distance = Math.Sqrt(indexOne + indexTwo);

            return distance;
        }

        public static Point[] FindClosestPoints(Point[] point)
        {
            double minDistance = double.MaxValue;
            
            Point[] closestTwoPoints = null;

            for (int i = 0; i < point.Length; i++)
            {
                for (int j = 1; j < point.Length; j++)
                {

                    double distance = CalcDistance(point[i], point[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { point[i], point[j] };
                    }

                }
            }

            return closestTwoPoints;
        }

        public static void PrintPoint(Point point)
        {
            Console.WriteLine("{0}, {1}",point.X,point.Y);
        }

        public static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}",distance);
        }


        
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
