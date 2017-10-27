using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = Console.ReadLine();

            while (pattern.Length > 0 && text.Length > pattern.Length)
            {
                if (text.Contains(pattern))
                {
                    int firsIndex = text.IndexOf(pattern);
                    int lastIndex = text.LastIndexOf(pattern);
                    if (firsIndex != lastIndex)
                    {
                        text = text.Remove(lastIndex, pattern.Length);

                        text = text.Remove(firsIndex, pattern.Length);

                        Console.WriteLine("Shaked it.");
                    }
                    else
                    {
                        Console.WriteLine("No shake.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                pattern = pattern.Remove(pattern.Length / 2, 1);
            }
            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
            }
            Console.WriteLine(text);
        }
    }
}