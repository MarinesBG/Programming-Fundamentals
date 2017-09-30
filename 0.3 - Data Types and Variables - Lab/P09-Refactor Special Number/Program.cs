using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Refactor_Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // THIS CODE IS BROKEN AND NOW WE MUST REFACTOR HIM !

            /*
                int kolkko = int.Parse(Console.ReadLine());
                int obshto = 0; int takova = 0; bool toe = false;
                for (int ch = 1; ch <= kolkko; ch++)
                {
                takova = ch;
                while (ch > 0)
                {
                   obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{takova} -> {toe}");
                obshto = 0;
                ch = takova;
                }
            */

            // REFACTORED CODE : 

            int specialNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= specialNumber; i++)
            {
                int sum = 0;
                int digits = i;  
                
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
               
              bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
             
            }







        }
    }
}
