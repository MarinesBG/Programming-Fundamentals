using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
           long n = long.Parse(Console.ReadLine());
            
            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(long n)
        {
                if (n == 1) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false;

                long boundary = (int)Math.Floor(Math.Sqrt(n));
        
                for (int i = 3; i <= boundary; i+=2)
                {
                    if (boundary % i == 0)
                    {
                        return true;
                    }
                    return false;   
                }
                return true;
        }
    }
}



