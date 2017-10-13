


using System.Numerics;

namespace P13_Factorial
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                
            }
            Console.WriteLine(factorial);

        }
    }
}
