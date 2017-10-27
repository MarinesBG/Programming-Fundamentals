using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"\b(\d{2})([.\-\/])([A-Za-z]{3})\2([0-9]{4})\b";

            string input = Console.ReadLine();


            foreach (Match m in Regex.Matches(input,regex))
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",m.Groups[1],m.Groups[3],m.Groups[4]);
                
            }
        }
    }
}
