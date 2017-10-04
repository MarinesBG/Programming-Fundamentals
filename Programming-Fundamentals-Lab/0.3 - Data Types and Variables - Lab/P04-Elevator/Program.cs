using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int maxPassengers = int.Parse(Console.ReadLine());

            int courses = (int) (Math.Ceiling((double)numberOfPeople / maxPassengers));
            Console.WriteLine(courses);
        }
    }
}
