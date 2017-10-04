using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureFromFahrenheitToCelsius();
        }
      
        private static void TemperatureFromFahrenheitToCelsius()
        {
            double inputTemperature = double.Parse(Console.ReadLine());
            double degreeInFahrenheit = inputTemperature;
            double degreeInCelsius = (degreeInFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{degreeInCelsius:F2}");  
        }
    }
}
