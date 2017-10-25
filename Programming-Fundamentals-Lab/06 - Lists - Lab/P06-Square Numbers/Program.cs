using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<int> sqrtNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]) )
                {
                        sqrtNumbers.Add((int)numbers[i]);
                }
            }
            Console.WriteLine(String.Join(" ",sqrtNumbers));
        }
    }
}
