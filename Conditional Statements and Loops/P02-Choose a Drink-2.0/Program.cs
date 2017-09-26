
namespace P02_Choose_a_Drink_2._0
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());


            double totalPrice;

            switch (profession)
            {
                case "Athlete":
                    double water = 0.70;
                    totalPrice = quantity * water;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    double coffee = 1.00;
                    totalPrice = quantity * coffee;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                case "SoftUni Student":
                    double beer = 1.70;
                    totalPrice = quantity * beer;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                default:
                    double tee = 1.20;
                    totalPrice = quantity * tee;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
            }


        }
    }
}
