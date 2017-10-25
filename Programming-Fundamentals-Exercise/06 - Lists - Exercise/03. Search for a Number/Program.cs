using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arrNumber = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int edit = arrNumber[0];
            int delete = arrNumber[1];
            int check = arrNumber[2];


            List<int> editNumber = new List<int>(numbers.Take(edit));
            

            for (int i = 0; i < delete ; i++)
            {
                editNumber.RemoveAt(0);
            }

            if (editNumber.Contains(check))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }  
        }
    }
}
