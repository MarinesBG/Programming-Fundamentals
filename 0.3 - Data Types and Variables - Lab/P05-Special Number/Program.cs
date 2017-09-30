using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace P05_Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= specialNumber; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                   
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
    
        }
    }
}
