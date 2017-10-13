using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger trailingZeroes = 0;
            BigInteger lastZeroes = 1;
            BigInteger powerOfFive = 1;

            while (lastZeroes > 0)
            {
                powerOfFive *= 5;
                lastZeroes = number / powerOfFive;
                trailingZeroes += lastZeroes;
            }
            Console.WriteLine(trailingZeroes);
        }
    }
}
