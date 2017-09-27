using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = 1.60934;

            var kilometers = double.Parse(Console.ReadLine());

            var result = mile * kilometers;

            Console.WriteLine(result:F2);

        }
    }
}
