using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split('|').ToList();

            string input;
            
           
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                List<string> commandArg = input.Split(" ").ToList();
                string command = commandArg[0];
                switch (command)
                {
                    case "Loot":
                        string[] items = commandArg.Skip(1).ToArray();
                        AddItems(items, chest);
                        break;
                    case "Drop":
                        items = commandArg.Skip(1).ToArray();
                        int index = int.Parse(commandArg[1]);
                        DropItems(index, chest);
                        break;
                    case "Steal":
                        items = commandArg.Skip(1).ToArray();
                        int count = int.Parse(commandArg[1]);
                        StealItems(count, chest);
                        break;
                }
            }
            double averageSum = AvarageGet(chest);
            if (chest.Count != 0)
            { 
                Console.WriteLine($"Average treasure gain: {averageSum:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static double AvarageGet(List<string> chest)
        {
            double average = 0;
            foreach (var item in chest)
            {
                average += item.Length;
            }
            double sum = average / chest.Count;
            return sum;
        }

        private static void StealItems(int count, List<string> chest)
        {
            int index = chest.Count - count;
            string[] removeditems = null;

            if (index >= 0)
            {
                removeditems = chest.Skip(index).ToArray();
                Console.WriteLine(string.Join(", ", removeditems));
                chest.RemoveRange(index, count);
            }
            else
            {
                removeditems = chest.ToArray();
                Console.WriteLine(string.Join(", ", removeditems));
                chest.Clear();
            }


        }

        private static void DropItems(int index, List<string> chest)
        {
            if (index > 0 && index <= chest.Count - 1)
            {
                string item = chest[index];
                chest.Insert(chest.Count, item);
                chest.RemoveAt(index);
            }
        }

        private static void AddItems(string[] items, List<string> chest)
        {
            foreach (var item in items)
            {
                if (!chest.Contains(item))
                {
                    chest.Insert(0, item);
                }
            }
        }
    }
}
