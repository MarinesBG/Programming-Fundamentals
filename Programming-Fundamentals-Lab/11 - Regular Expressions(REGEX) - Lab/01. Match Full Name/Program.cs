using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+\b \b[A-Z][a-z]+\b)";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", m.Value);
            }
            Console.WriteLine();
        }
    }
}
