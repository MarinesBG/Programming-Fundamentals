using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            // DOESN'T READY !!! 

        }
    }
}
