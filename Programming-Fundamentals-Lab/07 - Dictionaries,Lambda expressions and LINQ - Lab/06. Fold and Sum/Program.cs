using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            int k = array.Length / 4;

            int[] leftSide = array.Take(k).Reverse().ToArray();

            int[] rightSide = array.Skip(3 * k).Take(k).Reverse().ToArray();

            int[] middle = array.Skip(k).Take(2 * k).ToArray();

            int[] concantenate = leftSide.Concat(rightSide).ToArray();

            var sum = middle.Select((x, index) => x + concantenate[index]).ToArray();

            Console.WriteLine(String.Join(" ",sum));

        }
    }
}
