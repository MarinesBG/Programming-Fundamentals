using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            List<int> numb = new List<int>(numbers);

            string[] select = Console.ReadLine()
                .Split(' ')
                .ToArray();


            while (select[0] != "print")
            {

                switch (select[0])
                {
                    case "add":

                        numb.Insert(Convert.ToInt32(select[1]), Convert.ToInt32(select[2]));

                        break;

                    case "addMany":

                        for (int i = select.Length - 1; i >= 2; i--)
                        {
                            int elementMany = int.Parse(select[i]);
                            numb.Insert(Convert.ToInt32(select[1]), elementMany);
                        }

                        break;

                    case "contains":

                        if (numb.Contains(Convert.ToInt32(select[1])))
                        {
                            for (int i = 0; i < numb.Count; i++)
                            {
                                if (Convert.ToInt32(select[1]) == numb[i])
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }

                        break;

                    case "remove":
                        numb.RemoveAt(Convert.ToInt32(select[1]));
                        break;

                    case "shift":

                        int numbe = Convert.ToInt32(select[1]) % numb.Count;
                        for (int i = 0; i < numbe; i++)
                        {
                            numb.Insert(numb.Count, numb[0]);
                            numb.Remove(numb[0]);
                        }

                        break;

                    case "sumPairs":

                        int count = 0;
                        List<int> listSum = new List<int>();
                        for (int i = 0; i < numb.Count; i += 2)
                        {
                            count++;
                            if (count <= numb.Count / 2)
                            {
                                listSum.Add(numb[i] + numb[i + 1]);
                            }
                            else
                            {
                                listSum.Add(numb[i]);
                            }
                        }
                        numb = listSum;

                        break;
                }

                select = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            }
            Console.Write("[");
            Console.Write(string.Join(", ", numb));
            Console.WriteLine("]");
        }
    }
}
