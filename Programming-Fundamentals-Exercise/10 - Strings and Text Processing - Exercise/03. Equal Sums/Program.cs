using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("number.txt")

                .Split(' ')

                .Select(int.Parse)

                .ToArray();



            int leftSum = 0;

            int rightSum = 0;

            int count = 0;



            for (int i = 0; i < numbers.Length; i++)

            {

                leftSum += numbers[i];

                for (int j = i + 2; j < numbers.Length; j++)

                {

                    rightSum += numbers[j];

                    if (leftSum == rightSum && j == numbers.Length - 1)

                    {

                        Console.WriteLine(i + 1);

                        count++;

                    }

                }

                rightSum = 0;

            }





            if (numbers.Length == 1)

            {

                Console.WriteLine("0");

            }

            else if (count == 0)

            {

                Console.WriteLine("no");

            }
        }
    }
}
