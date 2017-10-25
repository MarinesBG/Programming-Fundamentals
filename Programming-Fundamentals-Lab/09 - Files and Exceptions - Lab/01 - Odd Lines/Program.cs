using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 1)
                {
                    File.AppendAllText("NewFile.txt", lines[i] + Environment.NewLine);
                    
                }
            }

        }
    }
}
