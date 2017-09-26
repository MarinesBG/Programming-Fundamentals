using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var firstContent = volume * energyContent / 100.00;
            var secondContent = volume * sugarContent / 100.00;

            Console.WriteLine();
            Console.WriteLine(volume + "ml " + name + ":");
            Console.Write(firstContent + "kcal, ");
            if (secondContent % 1 == 0)
            {
                Console.WriteLine($"{secondContent}g sugars");
            }
            else
            {
                Console.WriteLine($"{secondContent}g sugars");
            }
            Console.WriteLine();
        }
    }
}
