using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyString = Console.ReadLine()
                .Split(new char[] { '|', '\\', '<' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            string startKey = keyString[0];
            string endKey = keyString[keyString.Length - 1];

            List<string> result = new List<string>();

            if (keyString.Length < 2) return;

            string pattern = @"((?<=(" + startKey + "))(\\w*?)(?=(" + endKey + ")))";

            foreach (Match word in Regex.Matches(text, pattern))
            {

                result.Add(word.Groups[2].ToString());
                
            }

            bool isEmpty = !result.Any();

            if (isEmpty)
            {
                Console.WriteLine("Empty result");
            }

            Console.WriteLine(String.Join("", result));
        }
    }
}

