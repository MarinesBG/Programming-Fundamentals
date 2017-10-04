using System;

namespace P01_Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
           ReceiptHeader();
            ReceiptBody();
            ReciptFooter();
        }
         private static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        private static void ReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void ReciptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.Write("\u00A9");
            Console.WriteLine(" SoftUni");
        }

    }
}
