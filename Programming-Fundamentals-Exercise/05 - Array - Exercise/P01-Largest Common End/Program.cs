using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = Algorithm(firstArr, secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            int rightCount = Algorithm(firstArr, secondArr);

            Console.WriteLine(Math.Max(leftCount, rightCount));
        }

        private static int Algorithm(string[] firstArr, string[] secondArr)
        {
            int count = 0;
            int length = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
        
    }
}

