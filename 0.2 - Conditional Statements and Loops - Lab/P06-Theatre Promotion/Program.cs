using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int visitorAge = int.Parse(Console.ReadLine());

            switch (dayType)
            {
                case "Weekday":
                    if (0 <= visitorAge && visitorAge <= 18)
                    {
                        Console.WriteLine("12$");
                    }

                    else if (18 < visitorAge && visitorAge <= 64)
                    {
                        Console.WriteLine("18$");
                    }

                    else if (64 < visitorAge && visitorAge <= 122)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (0 <= visitorAge && visitorAge <= 18)
                    {
                        Console.WriteLine("15$");
                    }

                    else if (18 < visitorAge && visitorAge <= 64)
                    {
                        Console.WriteLine("20$");
                    }

                    else if (64 < visitorAge && visitorAge <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (0 <= visitorAge && visitorAge <= 18)
                    {
                        Console.WriteLine("5$");
                    }

                    else if (18 < visitorAge && visitorAge <= 64)
                    {
                        Console.WriteLine("12$");
                    }

                    else if (64 < visitorAge && visitorAge <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;

            }



        }
    }
}
