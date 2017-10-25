using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumb = File.ReadAllText("FileOne.txt")
                .Split(new char[] { ' ', ',', '.', '!', '?', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondNumb = File.ReadAllText("FileTwo.txt")
                .Split(new char[] { ' ', ',', '.', '!', '?', '-', '\n', '\r' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> merge = new List<int>();


            for (int i = 0; i < firstNumb.Length; i++)
            {
                merge.Add(firstNumb[i]);
            }
            for (int i = 0; i < secondNumb.Length; i++)
            {
                merge.Add(secondNumb[i]);
            }

            foreach (var elem in merge.OrderBy(x => x))
            {
                File.AppendAllText("Merge.txt", elem  + Environment.NewLine);
            }
           

        }
    }
}
