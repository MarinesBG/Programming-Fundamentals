using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxtHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            char pipe = '|';

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: {0}{1}{2}{0}", pipe,
                new string('|', currentHealth),
                new string('.', maxtHealth - currentHealth), pipe);

            Console.WriteLine("Energy: {0}{1}{2}{0}", pipe,
                new string('|', currentEnergy),
                new string('.', maxEnergy - currentEnergy), pipe);
        }
    }
}
