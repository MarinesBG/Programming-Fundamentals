using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine(MathPowerOfNumber(2,8));
        }

        private static double MathPowerOfNumber(double number , byte exponent)
        {
            double resultPow = Math.Pow(number, exponent);
            return resultPow;
        }
    }
}
