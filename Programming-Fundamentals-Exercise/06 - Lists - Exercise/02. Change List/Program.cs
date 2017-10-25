using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
                

            string[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

           

            while (input[0] != "Odd" || input[0] != "Even")
            {

                switch (input[0])
                {
                    case "Delete":
                        for (int i = 0; i < number.Count; i++)
                        {
                            int delete = int.Parse(input[1]);
                            if (delete == number[i])
                            {
                                number.Remove(number[i]);
                                i--;
                            }
                        }
                        break;

                    case "Insert":
                        int insert = int.Parse(input[1]);
                        int position = int.Parse(input[2]);
                        number.Insert(position, insert);
                        break;

                    case "Odd":
                        foreach (var element in number)
                        {
                            if (element % 2 == 1)
                            {
                                Console.Write($"{element} ");
                            }
                        }
                        Console.WriteLine();
                        return;

                    case "Even":
                        foreach (var element in number)
                        {
                            if (element % 2 == 0)
                            {
                                Console.Write($"{element} ");
                            }
                        }
                        Console.WriteLine();
                        return;
                }

                input = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
            }  
        }
    }
}
