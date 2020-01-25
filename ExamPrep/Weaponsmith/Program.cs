using System;
using System.Collections.Generic;
using System.Linq;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponParts = Console.ReadLine().Split('|').ToList();

            string input;

            while ((input = Console.ReadLine()) != "Done")
            {
                List<string> commandArg = input.Split(" ").ToList();
                string command = commandArg[1];
                switch (command)
                {
                    case "Left":
                        int index = int.Parse(commandArg[2]);
                        MoveLeft(index, weaponParts);
                        break;
                    case "Right":
                        index = int.Parse(commandArg[2]);
                        MoveRight(index, weaponParts);
                        break;
                    case "Even":
                        for(int i = 0; i < weaponParts.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                PrintOddEven(i, weaponParts);
                            }
                        }
                        break;
                    case "Odd":
                        for (int i = 0; i < weaponParts.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                PrintOddEven(i, weaponParts);
                            }
                        }
                        break;
                }
            }
            Console.Write("\n");
            Console.WriteLine($"You crafted {string.Join("", weaponParts)}!");
        }

        private static void PrintOddEven(int i, List<string> weaponParts)
        {
            Console.Write($"{weaponParts[i]} ");
        }

        private static void MoveRight(int index, List<string> weaponParts)
        {
            if (index >= 0 && index < weaponParts.Count - 1)
            {
                string wordToMove = weaponParts[index];
                weaponParts.RemoveAt(index);
                weaponParts.Insert(index + 1, wordToMove);
            }
        }

        private static void MoveLeft(int index, List<string> weaponParts)
        {
            if (index >= 1 && index <= weaponParts.Count)
            {
                string wordToMove = weaponParts[index];
                weaponParts.RemoveAt(index);
                weaponParts.Insert(index - 1, wordToMove);
            }
        }
    }
}
