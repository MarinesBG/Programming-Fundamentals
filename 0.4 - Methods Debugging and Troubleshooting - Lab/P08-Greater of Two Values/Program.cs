using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreaterOfTwoValues("Ivan", "Todor"));
            Console.WriteLine(GreaterOfTwoValues(2, 16));
            Console.WriteLine(GreaterOfTwoValues('a', 'z'));
            
        }

        private static string GreaterOfTwoValues(string NameOfFirstMan , string NameOfSecondMan)
        {
            if (NameOfFirstMan.CompareTo(NameOfSecondMan) >= 0)
            {
                return NameOfFirstMan;
            }
            else
            {
                return NameOfSecondMan;
            }
        }

        private static int GreaterOfTwoValues(int numberOne,int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }
            else
            {
               return numberTwo; 
            }
        }

        private static char GreaterOfTwoValues(char symbolOne ,char symbolTwo)
        {
            if (symbolOne > symbolTwo)
            {
                return symbolOne;
            }
            else
            {
                return symbolTwo;
            }
        }
    }
}
