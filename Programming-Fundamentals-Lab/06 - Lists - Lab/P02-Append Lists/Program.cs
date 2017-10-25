using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> number = Console.ReadLine()
                .Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            number.Reverse();

            List<string> result = new List<string>();

            for (int i = 0; i < number.Count; i++)
            {

                int[] elements = number[i]
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
              
                
                result.AddRange(number);
                
               Console.Write(string.Join(" ",elements));
                Console.Write(" ");
                
            }
            Console.WriteLine();
        }
    }
}
