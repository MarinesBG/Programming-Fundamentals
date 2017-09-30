using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLatter = char.Parse(Console.ReadLine());
            char secondLatter = char.Parse(Console.ReadLine());
            char thirdLatter = char.Parse(Console.ReadLine());

            for (char i = firstLatter; i <= secondLatter; i++)
            {
                for (char j = firstLatter; j <= secondLatter; j++)
                {
                    for (char l = firstLatter; l <= secondLatter; l++)
                    {

                        if (i != thirdLatter && j != thirdLatter && l != thirdLatter)
                        {
                            Console.Write("{0}{1}{2} ", i, j, l);

                        }
                    }

                }
            }
        }
    }
}
