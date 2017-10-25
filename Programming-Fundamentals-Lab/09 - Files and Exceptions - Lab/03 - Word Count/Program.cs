using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            string[] text = File.ReadAllText("text.txt")
                .ToLower().Split(new char[] { ' ', ',', '.', '!', '?', '-', '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                dict[word] = 0;
            }
            foreach (var word in text)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
            }

            foreach (var item in dict.OrderByDescending(key => key.Value))
            {
                File.AppendAllText("NewFile.txt", item.Key + " - " + item.Value + Environment.NewLine);
            }
        }
    }
}
