using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = input; i > 1; i--)
            {
                factorial *= i;

            }
            Console.WriteLine(factorial);
        }
    }
}
