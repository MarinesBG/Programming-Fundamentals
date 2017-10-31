using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal n = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {

                decimal orderPrice = Input();

                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }

        private static decimal Input()
        {

            decimal price = decimal.Parse(Console.ReadLine());

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);

            decimal capsules = decimal.Parse(Console.ReadLine());

            decimal orderPrice = OrderPrice(price, date, capsules);

            return orderPrice;
        }

        private static decimal OrderPrice(decimal price, DateTime date, decimal capsules)
        {
            decimal dayInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal allPrice = (price * dayInMonth) * capsules;

            return allPrice;
        }
    }
}
