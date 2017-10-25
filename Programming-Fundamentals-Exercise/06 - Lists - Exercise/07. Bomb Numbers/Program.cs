using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] selectBomb = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bomb = selectBomb[0];
            int power = selectBomb[1];


            for (int i = 0; i < number.Count; i++)
            {
                if (bomb == number[i])
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, number.Count - 1);

                    int lenght = right - left + 1;

                    number.RemoveRange(left, lenght);

                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", number.Sum()));
        }
    }
}
