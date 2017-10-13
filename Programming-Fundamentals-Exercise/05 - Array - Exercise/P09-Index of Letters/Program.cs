using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            string stringValue = Console.ReadLine();

            var array = stringValue.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} -> {(int) (array[i]) - 97}");
            }
        }
    }
}
