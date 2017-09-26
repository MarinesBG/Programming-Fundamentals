

namespace P04_Hotel
{
    using System;

    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double studio;
            double doublee;
            double suite;
            double percentageStudio;
            double percentageDoublee;
            double percentageSuite;
            double priceStudio;
            double priceStudioFinal;
            double priceDoublee;
            double priceSuite;
            double priceDoubleeFinal;

            if (night >= 0 && night <= 200)
            {
                switch (month)
                {
                    case "May":
                        studio = 50;
                        doublee = 65;
                        suite = 75;

                        if (night > 7)
                        {
                            percentageStudio = 5 * studio / 100;
                            priceStudio = studio - percentageStudio;
                            priceStudio = priceStudio * night;
                            priceDoublee = doublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");

                        }
                        else
                        {
                            priceStudio = studio * night;
                            priceDoublee = doublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                        }
                        break;

                case "Octomber":
                        studio = 50;
                        doublee = 65;
                        suite = 75;
                                        
                    if (night > 7)
                    {
                        
                        percentageStudio = 5 * studio / 100;
                        priceStudio = night * studio - studio;
                        priceStudioFinal = priceStudio - percentageStudio;
                        
                        priceDoublee = doublee * night;
                        priceSuite = suite * night;
                        Console.WriteLine($"Studio: {priceStudioFinal:F2} lv.");
                        Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:F2} lv.");

                    }
                    else
                    {
                        priceStudio = studio * night;
                        priceDoublee = doublee * night;
                        priceSuite = suite * night;
                        Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                        Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                    }
                    break;

                    case "June":
                        studio = 60;
                        doublee = 72;
                        suite = 82;

                        if (night > 14)
                        {
                            percentageDoublee = 10 * doublee / 100;
                            priceDoublee = doublee - percentageDoublee;
                            priceStudio = studio * night;
                            priceDoubleeFinal = priceDoublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoubleeFinal:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");

                        }
                        else
                        {
                            priceStudio = studio * night;
                            priceDoublee = doublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                        }
                        break;

                case "September":
                        studio = 60;
                        doublee = 72;
                        suite = 82;
                        
                     if (night > 7)
                     {
                        priceStudio = studio * night - studio;
                        priceDoublee = doublee * night;
                        priceSuite = suite * night;
                        Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                        Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                     }
                    else if (night > 14)
                    {               
                            percentageDoublee = 10 * doublee / 100;
                            priceDoublee = doublee - percentageDoublee;                           
                            priceStudio = studio * night;
                            priceDoubleeFinal = priceDoublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoubleeFinal:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");

                    }
                       
                        else
                        {
                            priceStudio = studio * night;
                            priceDoublee = doublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                        }
                    break;

                    case "July":                       
                    case "August":                      
                    case "December":
                        studio = 68;
                        doublee = 77;
                        suite = 89;

                        if (night > 14)
                        {
                            percentageSuite = 15 * suite / 100;
                            priceSuite = suite - percentageSuite;
                            priceStudio = studio * night;
                            priceDoublee = doublee * night;
                            priceSuite = priceSuite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");

                        }
                        else
                        {
                            priceStudio = studio * night;
                            priceDoublee = doublee * night;
                            priceSuite = suite * night;
                            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                            Console.WriteLine($"Double: {priceDoublee:F2} lv.");
                            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
                        }
                    break;

                
                
                }

            }

        }
    }
}
