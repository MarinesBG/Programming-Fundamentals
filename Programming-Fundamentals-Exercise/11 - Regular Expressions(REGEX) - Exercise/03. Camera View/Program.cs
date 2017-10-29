using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();
            
            string[] splitText = text.Replace("|<", "|< ").Split(new string[] {"|<"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

          List<string> list = new List<string>();

            foreach (var split in splitText)
            {

                if (split.StartsWith(" "))
                {
                    var current = split.Skip(input[0] + 1).Take(input[1]).ToArray();
                    list.Add(new string(current));
                }
              
            }
            Console.WriteLine(String.Join(", ",list));
        }
    }
}
