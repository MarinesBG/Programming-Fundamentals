using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = 1;
            var currentCount = 0;
            int resultNumber = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {

                    count++;
                    if (count > currentCount)
                    {
                        currentCount = count;
                        resultNumber = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < currentCount; i++)
            {
                Console.Write("{0} ", resultNumber);
            }
            Console.WriteLine();
        }
    }
}
