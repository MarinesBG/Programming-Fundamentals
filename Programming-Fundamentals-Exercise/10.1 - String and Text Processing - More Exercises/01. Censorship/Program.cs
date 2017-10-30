using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string censor = Console.ReadLine();
            string sentence = Console.ReadLine();
            string asterisk = "";

            for (int i = 0; i < censor.Length; i++)
            {
                asterisk += "*";
            }
           sentence = sentence.Replace(censor, asterisk);

            Console.WriteLine(sentence);
        }
    }
}
