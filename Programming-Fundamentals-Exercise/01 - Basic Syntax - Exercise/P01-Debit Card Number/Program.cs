using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumb = int.Parse(Console.ReadLine());
            var secondNumb = int.Parse(Console.ReadLine());
            var thirdNumb = int.Parse(Console.ReadLine());
            var fourthNumb = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumb:D4} {secondNumb:D4} {thirdNumb:D4} {fourthNumb:D4} ");

        }
    }
}
