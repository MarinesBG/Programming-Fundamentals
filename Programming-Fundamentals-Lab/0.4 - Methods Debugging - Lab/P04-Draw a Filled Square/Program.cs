using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            PrintBodyRow(number);
            PrintHeaderRow(number);
        }

        private static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        private static void PrintBodyRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n - 1 ; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
           
        }
    }
}
