using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0;
            decimal totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
                char firstLatter = char.Parse(input[i].Substring(0, 1));
                char secondLatter = char.Parse(input[i].Substring(input[i].Length - 1));

                if (firstLatter <= 90 && firstLatter >= 65) // is upper
                {
                    sum = number / (firstLatter - 64);
                }
                else // is lower
                {
                    sum = number * (firstLatter - 96);
                }
                if (secondLatter <= 90 && secondLatter >= 65) // is upper 
                {
                    sum = sum - (secondLatter - 64);
                }
                else
                {
                    sum = sum + (secondLatter - 96);
                }

                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}