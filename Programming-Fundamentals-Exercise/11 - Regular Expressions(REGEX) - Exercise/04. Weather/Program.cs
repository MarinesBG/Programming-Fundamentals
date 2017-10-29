using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"([A-Z]{2})([0-9]{2}\.[0-9]{1,2})([A-Za-z]+)(\|)";

            string input = Console.ReadLine();


            List<Weather> listOfWeathers = new List<Weather>();

            while (input != "end")
            {
                foreach (Match reg in Regex.Matches(input,pattern))
                {
                    Weather weath = new Weather();
                    weath.Town = reg.Groups[1].ToString();
                   weath.Degrees= double.Parse(reg.Groups[2].ToString());
                   weath.Weathers = reg.Groups[3].ToString();

                    bool isTrue = false;
                    
                    for (int i = 0; i < listOfWeathers.Count; i++)
                    {

                        if (listOfWeathers[i].Town.Contains(weath.Town))
                        {
                            isTrue = true;
                            listOfWeathers[i].Degrees = weath.Degrees;
                            listOfWeathers[i].Weathers = weath.Weathers;
                        }
                    }

                    if (isTrue == false)
                    {
                        listOfWeathers.Add(weath);
                    }
                   
                }
                
                input = Console.ReadLine();
            }
            foreach (var current in listOfWeathers.OrderBy(x => x.Degrees))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", current.Town, current.Degrees, current.Weathers);
            }
            

        }
    }

    class Weather
    {
        public string Town { get; set; }
        public double Degrees { get; set; }
        public string Weathers { get; set; }  
    }
}
