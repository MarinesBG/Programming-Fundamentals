using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = times * i;
                Console.WriteLine($"{times} X {i} = {sum}");
            }
        }
    }
}
