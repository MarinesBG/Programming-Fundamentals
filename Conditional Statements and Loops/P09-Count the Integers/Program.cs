
namespace P09_Count_the_Integers
{
    using System;

    class Program
    {
        static void Main()
        {

            int sum = 0;
            while (true)
            {
                try
                {
                     int count = int.Parse(Console.ReadLine());
                     sum++;
                }
                catch (System.FormatException)
                {
                      Console.WriteLine(sum);
                      break;
                }
                catch (System.OverflowException)
                {
                      Console.WriteLine(sum);
                      break;
                } 
            }
        }
    }
}

