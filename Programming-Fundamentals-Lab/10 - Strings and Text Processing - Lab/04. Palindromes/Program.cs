using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', '!', '?', '/' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> palindrome = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                bool palind = IsPalindorme(text[i]);
                if (palind == true)
                {
                    palindrome.Add(text[i]);
                }

            }

            Console.WriteLine(String.Join(", ", palindrome.OrderBy(x => x).Distinct()));
        }

        private static bool IsPalindorme(string text)
        {

            string reverseText = new string(text.Reverse().ToArray());

            if (reverseText == text)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

