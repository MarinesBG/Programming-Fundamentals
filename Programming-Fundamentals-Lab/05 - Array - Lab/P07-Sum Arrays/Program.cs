using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = Math.Max(arrOne.Length, arrTwo.Length);

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ",arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length] );
            }
            Console.WriteLine();
        }
    }
}
