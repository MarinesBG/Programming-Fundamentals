using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {'@'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            char[] firstPart = input[0].ToCharArray();
            char[] secondPart = input[1].ToCharArray();

            int firstSum = 0;
            int secondSum = 0;

            int current = 0;
            
            for (int i = 0; i < firstPart.Length; i++)
            {

                current = Convert.ToInt32(firstPart[i]);
                firstSum += current;
                

            }

            for (int i = 0; i < secondPart.Length; i++)
            {
                current = Convert.ToInt32(secondPart[i]);
                secondSum += current;
                
            }

            int totalSum = firstSum - secondSum;

            if (totalSum >= 0)
            {
                 Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
