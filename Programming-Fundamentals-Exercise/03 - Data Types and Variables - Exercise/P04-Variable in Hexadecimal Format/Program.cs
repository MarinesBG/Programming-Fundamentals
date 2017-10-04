using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P04_Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalFormat = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalFormat,16));

        }
    }
}
