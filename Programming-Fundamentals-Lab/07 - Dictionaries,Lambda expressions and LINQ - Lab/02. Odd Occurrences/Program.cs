using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var count = new Dictionary<string,int>();

            foreach (var element in words)
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

            List<string> results = new List<string>();
            foreach (var item in count)
            {
                if (item.Value % 2 != 0)
                    results.Add(item.Key);
            }

            Console.WriteLine(string.Join(", ",results));
        }
    }
}
