using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int firstMagic = 0;
            int secondMagic = 0;
            var count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        firstMagic = i;
                        secondMagic = j;
                    }
                    count++;
                }
            }
            if (firstMagic == 0)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
            else
            {
                Console.WriteLine($"Number found! {firstMagic} + {secondMagic} = {magic}");
            }
        }
    }
}
