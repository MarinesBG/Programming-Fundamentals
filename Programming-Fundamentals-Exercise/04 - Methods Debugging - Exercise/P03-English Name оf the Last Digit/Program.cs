using System;

namespace P03_English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string n = Console.ReadLine();
            Console.WriteLine(a[int.Parse(n[n.Length - 1].ToString())]);
        } 
    }
}
