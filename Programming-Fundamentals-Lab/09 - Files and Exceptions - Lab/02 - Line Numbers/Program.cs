using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = File.ReadAllLines("Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("NewFile.txt", i + 1 +"." + "  " + text[i] + Environment.NewLine);
            }
            
        }
    }
}
