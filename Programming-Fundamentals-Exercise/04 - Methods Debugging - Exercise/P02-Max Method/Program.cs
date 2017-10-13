using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
        }

        private static int GetMax(int a , int b)
        {

            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
