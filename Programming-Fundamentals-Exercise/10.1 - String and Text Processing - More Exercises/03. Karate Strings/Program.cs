using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine()
                .Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int length = 0;
            int currentLetght = 0;
            for (int i = 1; i < input.Count; i++)
            {
                char first = input[i].First();
                int strength = Convert.ToInt32(first - 48);

                length = input[i].Length;

                input[i] = new String(input[i].Skip(strength + currentLetght).ToArray());

                currentLetght = 0;

                if (strength > length)
                {
                    currentLetght = strength - length;
                    
                }
                
            }

            Console.WriteLine(String.Join(">", input));
        }
    }
}
