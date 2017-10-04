using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // THIS CODE MUST BE REFACTORED :

         /*   
            double dul, sh, V = 0;
            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            V = double.Parse(Console.ReadLine());
            V = (dul + sh + V) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
         */


            // REFACTORED CODE :

            Console.Write("Lenght: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Widht: ");
            double widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            height = (lenght + widht + height) / 3;

            Console.WriteLine($"Pyramid Volume: {height:F2}");
        }
    }
}
