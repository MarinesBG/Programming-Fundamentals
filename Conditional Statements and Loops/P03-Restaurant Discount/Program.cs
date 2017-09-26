


namespace P03_Restaurant_Discount
{
    using System;
    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (people <= 50 )
            {
                int smallHall = 2500;
                double sum;
                double percentage;
                double totalPrice;
                double pricePerPerson;

                switch (package)
                {
                    case "Normal":
                        int normal = 500;
                        sum = smallHall + normal;
                        percentage = sum * 5 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Gold":
                        int gold = 750;
                        sum = smallHall + gold;
                        percentage = sum * 10 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Platinum":
                        int platinum = 1000;
                        sum = smallHall + platinum;
                        percentage = sum * 15 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                }
               


            }
            else if (people > 50 && people <= 100)
            {
                int terrace = 5000;
                double sum;
                double percentage;
                double totalPrice;
                double pricePerPerson;


                switch (package)
                {
                    case "Normal":
                        int normal = 500;
                        sum = terrace + normal;
                        percentage = sum * 5 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Gold":
                        int gold = 750;
                        sum = terrace + gold;
                        percentage = sum * 10 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Platinum":
                        int platinum = 1000;
                        sum = terrace + platinum;
                        percentage = sum * 15 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                }
            }
            else if (people > 100 && people <= 120)
            {
                int greatHall = 7500;
                double sum;
                double percentage;
                double totalPrice;
                double pricePerPerson;


                switch (package)
                {
                    case "Normal":
                        int normal = 500;
                        sum = greatHall + normal;
                        percentage = sum * 5 / 100 ;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Gold":
                        int gold = 750;
                        sum = greatHall + gold;
                        percentage = sum * 10 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                    case "Platinum":
                        int platinum = 1000;
                        sum = greatHall + platinum;
                        percentage = sum * 15 / 100;
                        totalPrice = sum - percentage;
                        pricePerPerson = totalPrice / people;
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
