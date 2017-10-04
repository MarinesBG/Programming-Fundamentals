using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(value, 16).ToUpper();
            string binary = Convert.ToString(value, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
