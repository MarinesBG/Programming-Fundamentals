using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double deduction = firstNumber - secondNumber;
            deduction = Math.Abs(deduction);

            if (deduction < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
