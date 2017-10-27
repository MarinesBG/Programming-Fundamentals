using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
            {
               second = second.PadLeft(first.Length, '0');
            }
            else if (second.Length > first.Length)
            {
               first = first.PadLeft(second.Length, '0');
            }

            var firstReverse = first.ToCharArray().Reverse().ToArray();
            var secondReverse = second.ToCharArray().Reverse().ToArray();


            StringBuilder sb = new StringBuilder();

            int saveFirst ;
            int saveSecond;
            int sum ;
            int reminder = 0;

            for (int i = 0; i < firstReverse.Length; i++)
            {
                saveFirst = firstReverse[i] - 48;
                

                for (int j = i; j < secondReverse.Length;)
                {
                    saveSecond = secondReverse[j] - 48;
                    
                    sum = saveFirst + saveSecond + reminder;
                    reminder = 0;
                    if (sum == 10)
                    {
                        reminder = 1;
                        sum = 0;
                        
                    }
                    else if(sum > 10)
                    {
                        sum = sum % 10;
                        reminder = 1;
                    }
                    sb.Append(sum);
                   break;
                }
            }
            if (reminder != 0)
            {
                sb.Append(reminder);
            }
            Console.WriteLine(new string(sb.ToString().Reverse().ToArray()).TrimStart('0'));
        }
    }
}

