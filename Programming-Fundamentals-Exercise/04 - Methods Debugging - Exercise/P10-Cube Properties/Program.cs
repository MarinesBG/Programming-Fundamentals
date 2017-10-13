using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            double diagonal = double.Parse(Console.ReadLine());
            string chooseVariantForSum = Console.ReadLine();

            switch (chooseVariantForSum)
            {
                case "face":
                    Console.WriteLine(Face(diagonal));
                    break;
                case "space":
                    Console.WriteLine(Space(diagonal));
                    break;
                case "volume":
                    Console.WriteLine(Volume(diagonal));
                    break;
                case "area":
                    Console.WriteLine(Area(diagonal));
                    break;
            }

        }

        private static double Face(double diagonal)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(diagonal, 2));
            return Math.Round(faceDiagonal,2);
        }

        private static double Space(double diagonal)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(diagonal,2));
            return Math.Round(spaceDiagonal, 2);
        }

        private static double Volume(double diagonal)
        {
            double volumeDiagonal = Math.Pow(diagonal, 3);
            return Math.Round(volumeDiagonal, 2);
        }

        private static double Area(double diagonal)
        {
            double areaDiagonal = 6 * Math.Pow(diagonal, 2);
            return Math.Round(areaDiagonal, 2);
        }

    }
}
