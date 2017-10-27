using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string first = input[0];
            string second = input[1];

            char[] firstWord = first.ToCharArray().Distinct().ToArray();
            char[] secondWord = second.ToCharArray().Distinct().ToArray();


            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


        }
    }
}
