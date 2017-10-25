using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            int count = 1;
            int currentCount = 0;
            int currentNumber = 0;

            for (int i = 0; i < numbers.Count -1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;
                    if (count > currentCount)
                    {
                        currentCount = count;
                        currentNumber = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (currentCount == 0)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < currentCount; i++)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
            
            Console.WriteLine();
        }
    }
}
