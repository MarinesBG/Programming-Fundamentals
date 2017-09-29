using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;


            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum = sum + 3 * i * j;
                    count++;
                    if (sum >= max)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
