using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            ushort[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToArray();


            int count;
            int maxNumber = 0;
            int currentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] == numbers[j])
                    {

                        count++;
              
                        if (count > currentCount)
                        {
                            currentCount = count;
                            maxNumber = numbers[i];
                            
                        }
                    }
                    
                }
            }
            if (currentCount > 0)
            {
                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.WriteLine(numbers[0]);
            }
            
        }
    }
}
