
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Schema;

namespace P08_Calories_Counter
{
    using System;
    class Program
    {
        static void Main()
        {
            int numberOfProduct = int.Parse(Console.ReadLine());

            int calories = 0;

            if (numberOfProduct > 0 && numberOfProduct <= 20)
            {
                for (int i = 1; i <= numberOfProduct; i++)
                {  
                    string ingredients = Console.ReadLine().ToLower();

                    switch (ingredients)
                         {
                            case "cheese":
                                calories += 500;
                                break;
                            case "tomato sauce":
                                calories += 150;
                                break;
                            case "salami":
                                calories += 600;
                                break;
                            case "pepper":
                                calories += 50;
                                break;
                            default:
                                calories += 0;
                                break;
                         }                                     
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
