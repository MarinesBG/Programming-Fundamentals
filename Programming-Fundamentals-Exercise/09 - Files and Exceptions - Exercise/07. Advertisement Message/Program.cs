using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(File.ReadAllText("Input.txt"));

            string[] prases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();



            for (int i = 0; i < input; i++)

            {

                string phrasesOutput = prases[rnd.Next(0, prases.Length)];

                string eventsOutput = events[rnd.Next(0, events.Length)];

                string authorsOutput = autors[rnd.Next(0, autors.Length)];

                string citiesOutput = cities[rnd.Next(0, cities.Length)];

                File.AppendAllText("output.txt", $"{phrasesOutput} {eventsOutput} {authorsOutput} {citiesOutput}" + Environment.NewLine);

            }
        }
    }
}
