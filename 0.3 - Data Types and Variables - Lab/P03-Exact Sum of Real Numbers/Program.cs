using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            decimal sum = 0M; 
            for (int i = 1; i <= number; i++)
            {
              double n = double.Parse(Console.ReadLine());
                sum += (decimal) n;

            }
            Console.WriteLine(sum);
        }
    }
}
