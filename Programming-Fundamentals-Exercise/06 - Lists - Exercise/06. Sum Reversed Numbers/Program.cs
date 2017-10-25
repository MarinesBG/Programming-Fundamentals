using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> number = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

               
            List<int> reversedNumbers = new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                string numb = number[i];
                string reversedStr = reverseTheString(numb);
                int num = int.Parse(reversedStr);
                reversedNumbers.Add(num);
            }

            Console.WriteLine(string.Join(" ",reversedNumbers.Sum()));
        }


        private static string reverseTheString(string number)
        {
            char[] arr = number.ToCharArray();
            char[] reversed = arr.Reverse().ToArray();
            string reversedString = string.Join("", reversed);
            return reversedString;
        }
    }
}
