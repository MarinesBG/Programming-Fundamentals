using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            int magicNumber = int.Parse(Console.ReadLine());
            
            int[] firstdNumsToInt = firstNumber.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            
            List<int> resultNumber = new List<int>();

            int rem = 0;

            for (int i = firstdNumsToInt.Length - 1; i >= 0; i--)
            {
                int multiply = magicNumber * firstdNumsToInt[i] + rem;

                if (multiply > 9)
                {
                    rem = multiply / 10;
                    multiply = multiply % 10;
                }
                else
                {
                    rem = 0;
                }
                resultNumber.Add(multiply);
            }
            if (rem != 0)
            {
                resultNumber.Add(rem);
            }

            resultNumber.Reverse();

            while (resultNumber[0] == 0 && resultNumber.Count > 1)
            {
                resultNumber.RemoveRange(0, 1);
            }
            
            foreach (var item in resultNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
