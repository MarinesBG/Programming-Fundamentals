using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] username = Console.ReadLine()
                .Split(new char[] { ' ', ',', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);


            string pattern = @"^([a-zA-Z])([\w]{2,24})$";

            List<string> validUsername = new List<string>();

            for (int i = 0; i < username.Length; i++)
            {
                foreach (Match user in Regex.Matches(username[i], pattern))
                {
                    validUsername.Add(user.Value);
                }
            }

            int count = 0;
            int currentSum = 0;
            List<string> result = new List<string>();

            for (int i = 0; i < validUsername.Count - 1; i++)
            {
                currentSum = validUsername[i].Length + validUsername[i + 1].Length;

                if (currentSum > count)
                {
                    result.Add(validUsername[i]);
                    result.Add(validUsername[i+1]);
                    count = currentSum;
                }
                currentSum = 0;
            }
            Console.WriteLine(String.Join("",result[result.Count - 2]));
            Console.WriteLine(String.Join("", result[result.Count - 1]));
        }
    }
}
