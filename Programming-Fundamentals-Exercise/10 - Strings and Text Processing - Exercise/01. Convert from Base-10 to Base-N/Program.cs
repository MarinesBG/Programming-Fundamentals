using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            List<BigInteger> result = new List<BigInteger>();

            BigInteger divide = 0;


            while (input[1] > 0)
            {
                divide = input[1] % input[0];

                input[1] = input[1] / input[0];

                result.Add(divide);
            }
            result.Reverse();
            Console.WriteLine(String.Join("",result));
        }
    }
}
