using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            int sum = 0;

            if (times > 10)
            {
                sum = n * times;
                Console.WriteLine($"{n} X {times} = {sum}");
            }
            for (int i = times; i <= 10; i++)
            {
                sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
