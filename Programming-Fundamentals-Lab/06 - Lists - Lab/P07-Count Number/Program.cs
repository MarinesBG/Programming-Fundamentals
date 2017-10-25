using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Count_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var count = new Dictionary<int, int>();

            foreach (var element in numbers)
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

            var result = new Dictionary<int,int>();

            foreach (var element in count.Keys.OrderBy(x => x))
            {
                result.Add(element, count[element]);
                
                Console.WriteLine("{0} -> {1}",element,count[element]);

            }
            
        }
    }
}
