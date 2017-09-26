
namespace P06_Interval_of_Numbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= 0 &&
                   firstNumber <= 100 &&
                   secondNumber >= 0 && 
                   secondNumber <= 100 &&
                   firstNumber != secondNumber )
            {
                if (firstNumber < secondNumber)
                {
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        Console.WriteLine(i);
                    }  
                }
                else
                {
                    for (int i = secondNumber; i <= firstNumber; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
