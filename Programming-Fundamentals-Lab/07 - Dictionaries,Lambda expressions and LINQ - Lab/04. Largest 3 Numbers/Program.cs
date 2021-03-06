﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            if (numbers.Count > 2)
            {
                Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));
            }
            
        }
    }
}
