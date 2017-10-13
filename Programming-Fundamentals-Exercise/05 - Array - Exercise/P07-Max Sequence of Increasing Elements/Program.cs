using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = 0;
            var currentCount = 0;
            var startNumber = 0;
            var endNumber = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    count++;

                    if (count > currentCount)
                    {
                        currentCount = count;
                        startNumber = i - count;
                        endNumber = i;
                    }
                }
                else
                {
                    count = 0;
                }

            }


            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
