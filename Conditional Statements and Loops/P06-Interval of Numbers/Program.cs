
namespace P06_Interval_of_Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(firstNumber, secondNumber);
            int minNumber = Math.Min(firstNumber, secondNumber);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
