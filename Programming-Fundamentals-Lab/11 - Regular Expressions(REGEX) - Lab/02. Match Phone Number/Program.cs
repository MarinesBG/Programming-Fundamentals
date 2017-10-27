using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            List<string> phone = new List<string>();

            foreach (Match m in Regex.Matches(phones, regex))
            {
                phone.Add(m.Value);
            }
            Console.WriteLine(String.Join(", ",phone));

        }
    }
}
