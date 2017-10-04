using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string secondName ="Jonson";
            byte age = 27;
            char ch ='f';
            long numberOne = 8306112507;
            long numberTwo = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {secondName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {ch}");
            Console.WriteLine($"Personal ID: {numberOne}");
            Console.WriteLine($"Unique Employee number: {numberTwo}");
        }
    }
}
