using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"\b(?:0x)?[0-9A-F]+\b";

            string input = Console.ReadLine();

            foreach (Match hex in Regex.Matches(input,regex))
            {

                Console.Write(hex.Value + " ");
                
            }
            Console.WriteLine();
        }
    }
}
