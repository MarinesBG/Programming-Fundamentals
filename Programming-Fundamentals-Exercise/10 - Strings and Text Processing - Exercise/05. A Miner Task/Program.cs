using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("key.txt");
            var minerTaskDict = new Dictionary<string, long>();
            
            for (int i = 0; i < input.Length * 2 - 2; i = i + 2)
            {
                string inputKey = input[i];
                if (inputKey == "stop") break;
                string inputValueS = input[i + 1];
                if (inputValueS == "stop") break;
                int inputValue = int.Parse(input[i + 1]);
                if (!minerTaskDict.ContainsKey(inputKey))
                {
                    minerTaskDict.Add(inputKey, 0);
                }
                minerTaskDict[inputKey] += inputValue;
            }

            foreach (var item in minerTaskDict.Keys)
            {
                File.AppendAllText("output.txt", $"{item} -> { minerTaskDict[item]}" + Environment.NewLine);
            }
        }
    }
}
