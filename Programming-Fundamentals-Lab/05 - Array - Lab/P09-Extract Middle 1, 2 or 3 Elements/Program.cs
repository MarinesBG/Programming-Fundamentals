using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P09_Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            element();
        }

        private static void element()
        {
            string[] array = Console.ReadLine().Split(' ');

            if (array.Length == 1)
            {
                Console.WriteLine(string.Join(" ",array[0]));
            }
            else if (array.Length % 2 == 0)
            {
                string evenOne = array[array.Length / 2];
                string evenTwo = array[array.Length / 2 - 1];
                Console.Write("{ ");
                Console.Write(string.Join(", ",evenTwo,evenOne));
                Console.WriteLine(" }");

            }
            else if (array.Length % 2 == 1)
            {
                string addOne = array[array.Length / 2 - 1];
                string addTwo = array[array.Length / 2];
                string addThree = array[array.Length / 2 + 1];
                Console.Write("{ ");
                Console.WriteLine(string.Join(", ", addOne, addTwo, addThree));
                Console.WriteLine(" }");
            }
        }
    }
}

