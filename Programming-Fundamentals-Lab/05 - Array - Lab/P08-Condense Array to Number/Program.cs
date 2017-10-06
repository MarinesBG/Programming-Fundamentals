using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace P08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbs.Length > 1)
            {
                int[] condensed = new int[numbs.Length - 1];

                for (int i = 0; i < numbs.Length - 1; i++)
                {
                    condensed[i] = numbs[i] + numbs[i + 1];
                }

                numbs = condensed;
            }

            Console.WriteLine(numbs[0]);
        }
    }
}
