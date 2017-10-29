using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { "?", "&" }, StringSplitOptions.None);

            string pattern = @"\b.*=.*\S";

            var dict = new Dictionary<string, List<string>>();

            while (input[0] != "END")
            {
                dict = new Dictionary<string, List<string>>();

                for (int i = 0; i < input.Length; i++)
                {
                    foreach (Match m in Regex.Matches(input[i], pattern))
                    {
                        List<string> keyValue = m.Value.Split('=').ToList();

                        string[] keyConvert = keyValue[0]
                            .Split(new string[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries);

                        string[] valueConvert = keyValue[1]
                            .Split(new string[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries);

                        string key = string.Join(" ", keyConvert);

                        string value = string.Join(" ", valueConvert);

                        if (!dict.ContainsKey(key))
                        {
                            dict.Add(key, new List<string>());
                            dict[key].Add(value);
                        }
                        else
                        {
                            dict[key].Add(value);
                        }
                    }
                }
                foreach (var item in dict)
                {
                    Console.Write($"{item.Key}=[{String.Join(", ", item.Value)}]");
                }
                Console.WriteLine();
                input = Console.ReadLine().Split(new string[] { "?", "&" }, StringSplitOptions.None);
            }
        }
    }
}
