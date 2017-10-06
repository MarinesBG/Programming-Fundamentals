using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 1;

            for (int current = 1; current < array.Length; current++)
            {
                int start = Math.Max(0, current - k);
                int end = current - 1;
                int sum = 0;
                for (int prev = start; prev <= end; prev++)
                {
                    sum += array[prev];
                }
                array[current] = sum;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }

    }
}
