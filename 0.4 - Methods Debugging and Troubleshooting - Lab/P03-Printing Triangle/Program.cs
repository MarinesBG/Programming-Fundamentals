using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
         PrintTopSideOfTheTriangle(5);
        }

        private static void PrintTopSideOfTheTriangle(int number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j <= i -1 ; j++)
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine();
        }

        // THIS IS MIDDLE METHOD FOR WRITE ALL NUMBER OF ( '1' TO 'N' ) IN ONE ROW !
        /*
        private static void PrintMiddleSideOfTheTriangle()
        {
            
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
            }
        }
        */

        private static void PrintBotSideOfTheTriangle(int number)
        {
       
        }

       
    }
}
