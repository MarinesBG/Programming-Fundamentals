using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int a = 0;
            int b = 0;
            int c = 0;


            for (int i = 0; i < array.Length - 1 ; i++)
            {
                 a = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                     b = array[j];

                    for (int k = 0; k < array.Length; k++)
                    {
                         c = array[k];

                       if (a >= 0 && b >= 0 && a + b == c)
                        {
                            Console.WriteLine($"{a} + {b} == {c}");
                            count++;
                            break;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
