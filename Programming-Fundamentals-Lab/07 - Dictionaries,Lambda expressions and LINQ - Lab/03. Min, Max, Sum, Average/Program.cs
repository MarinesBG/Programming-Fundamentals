using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] number = new int[input];

            for (int i = 0; i < input; i++)
            {
               int n = int.Parse(Console.ReadLine());
                number[i] = n;

            }
            Console.Write("Sum = ");
            Console.WriteLine(string.Join("",number.Sum()));
            Console.Write("Min = ");
            Console.WriteLine(string.Join("",number.Min()));
            Console.Write("Max = ");
            Console.WriteLine(string.Join("",number.Max()));
            Console.Write("Average = ");
            Console.WriteLine(string.Join("",number.Average()));
        }
    }
}
