using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_String_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = "Hello ";
            string inputTwo = "World"; 
             
            Console.WriteLine(string.Concat(inputOne,inputTwo));
        }
    }
}
