


namespace P03_Restaurant_Discount
{
    using System;
    class Program
    {
        static void Main()
        {
            int numberOfGroup = int.Parse(Console.ReadLine());
            string thePackage = Console.ReadLine();
            var price = 0.0;
            var discount = 0.0;
            string hall = "";

            if (numberOfGroup >= 0 && numberOfGroup <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (numberOfGroup > 50 && numberOfGroup <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (numberOfGroup > 100 && numberOfGroup <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }

            if (thePackage == "Normal")
            {
                discount = 0.05;
                price = price + 500;
            }
            else if (thePackage == "Gold")
            {
                discount = 0.10;
                price = price + 750;

            }
            else if (thePackage == "Platinum")
            {
                discount = 0.15;
                price = price + 1000;

            }

            var sumofdiscound = price * discount;
            var leftPrice = price - sumofdiscound;

            var perPerson = leftPrice / numberOfGroup;

            if (hall != "")
            {
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine($"The price per person is {perPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
