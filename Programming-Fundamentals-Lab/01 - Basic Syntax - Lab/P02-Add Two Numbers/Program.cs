﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            // Console.WriteLine("{1} + {2} = {0}",sum,a,b);
            // Console.WriteLine(a + " + " + b + " = " + sum);
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}