using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstNumber = 5;
            byte secondNumber = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {secondNumber}");
            Console.WriteLine("After:");
            int exchange = firstNumber;

            firstNumber = secondNumber;
            
            Console.WriteLine($"a = {firstNumber}");
            Console.WriteLine($"b = {exchange}");
        }
    }
}
