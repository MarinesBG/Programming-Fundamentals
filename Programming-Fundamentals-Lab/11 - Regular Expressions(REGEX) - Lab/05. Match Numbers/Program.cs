using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string regex = @"(^|(?<=\s))-?[0-9]+(\.[0-9]+)?($|(?=\s))";



            foreach (Match reg in Regex.Matches(input,regex))
            {
                Console.Write(reg.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
