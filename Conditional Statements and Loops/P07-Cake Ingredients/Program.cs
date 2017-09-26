
using System.CodeDom;
using System.Linq.Expressions;

namespace P07_Cake_Ingredients
{
    using System;

    class Program
    {
        static void Main()
        {         
            string ingredient = Console.ReadLine();
            for (int i = 0; ingredient.Length <= 20; i++)
            {
                    if (ingredient == "Bake!")
                    {
                        Console.WriteLine($"Preparing cake with {i} ingredients.");
                        break;
                    }
                    else
                    {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                        ingredient = Console.ReadLine();
                    }
                
                    
            }
        }
    }
}
