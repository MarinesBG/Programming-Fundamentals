using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            if (name.ToLower() == "stop") return;

            string email = "";

            int count = 0;

            Dictionary<string, string> dict = new Dictionary<string, string>();



            while (name.ToLower() != "stop" || email.ToLower() != "stop")

            {

                string[] input = File.ReadAllLines("Input.txt");

                name = input[count];

                if (name.ToLower() == "stop") break;

                email = input[count + 1];



                if (!dict.ContainsKey(name))

                {

                    dict.Add(name, email);

                }

                else

                {

                    dict[name] = email;

                }



                string check = email.Substring(email.Length - 2);



                if (check == "uk" || check == "us")

                {

                    dict.Remove(name);

                }

                count += 2;

            }



            foreach (var item in dict.Keys)

            {

                File.AppendAllText("output.txt", $"{item} -> {dict[item]}" + Environment.NewLine);

            }
        }
    }
}
