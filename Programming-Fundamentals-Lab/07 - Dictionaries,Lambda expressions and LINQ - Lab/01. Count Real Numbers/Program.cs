using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numb = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var element in numb)
            {
                if (count.ContainsKey(element))
                {
                    count[element]++;
                }
                else
                {
                    count[element] = 1;
                }
            }

            foreach (var element in count.Keys)
            {
                Console.WriteLine($"{element} -> {count[element]}");
            }
        }
    }
}
