
using System.Collections.Generic;
using System.Linq;

namespace _04.Character_Multiplier
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] wordOne = input[0].ToCharArray();
            char[] wordTwo = input[1].ToCharArray();

            int max = Math.Max(wordOne.Length, wordTwo.Length);

            double sum = 0;
            int firsNumber = 0;
            int secondNumber = 0;

            for (int i = 0; i < max; i++)
            {
                if (i < wordOne.Length)
                {
                    firsNumber = (int)wordOne[i];
                }
                else
                {
                    firsNumber = 1;
                }

                if (i < wordTwo.Length)
                {
                    secondNumber = (int)wordTwo[i];
                }
                else
                {
                    secondNumber = 1;
                }
                sum += firsNumber * secondNumber;
            }
            Console.WriteLine(sum);

        }
    }
}
