using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int firstIndex = random.Next(0, words.Length);

                string reminder = words[firstIndex];

                int secondIndex = random.Next(0, words.Length);


                words[firstIndex] = words[secondIndex];
                words[secondIndex] = reminder;
                
            }
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
