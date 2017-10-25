using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _01.Day_of_Week
{
    class Program
    {
        public static void Main()
        {

            string input = Console.ReadLine();

            DateTime time = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(time.DayOfWeek);

        }
    }
}
