using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 1;

            while (peshoHealth > 1 || goshoHealth > 1)
            {
                if (round % 2 != 0)
                {
                    goshoHealth -= goshoDamage;
                    if (goshoHealth > 0)
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        return;
                    }
                }
                else
                {
                    peshoHealth -= peshoDamage;
                    if (peshoHealth > 0)
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");

                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        return;
                    }
                }
                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                round++;
            }
        }
    }
}
