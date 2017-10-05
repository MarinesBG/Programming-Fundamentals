using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            number = Math.Abs(number);
            int evenDigitSum = GetSumOfOddOrEvenDigits(number, true);
            int oddDigitSum = GetSumOfOddOrEvenDigits(number, false);
            return evenDigitSum * oddDigitSum;
        }

        static int GetSumOfOddOrEvenDigits(int number, bool isEven)
        {
            int remainder = isEven ? 0 : 1;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == remainder)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
        
