using System;
using System.Linq;
using System.Collections.Generic;
namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ").ToList();
            string input;


            while ((input = Console.ReadLine()) != "Stop")
            {
                List<string> commandArg = input.Split(" ").ToList();
                string command = commandArg[0];
                switch (command)
                {
                    case "Delete":

                        int index = int.Parse(commandArg[1]) + 1;
                        DeleteWord(index, words);
                        break;
                    case "Swap":
                        string firstWord = commandArg[1];
                        string secondWord = commandArg[2];
                        SwapWordsMet(firstWord, secondWord, words);

                        break;
                    case "Put":
                        string word = commandArg[1];
                        int indexWord = int.Parse(commandArg[2]) - 1;
                        PutWord(word, indexWord, words);
                        break;
                    case "Sort":
                        words.Sort();
                        words.Reverse();
                        break;
                    case "Replace":
                        string firstReplace = commandArg[1];
                        string secondReplace = commandArg[2];
                        ReplaceWord(firstReplace,secondReplace, words);
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", words));
        }

        private static void ReplaceWord(string firstReplace, string secondReplace, List<string> words)
        {
            if(words.Contains(secondReplace))
            {
                int secondWordIndex = words.IndexOf(secondReplace);
                words.RemoveAt(secondWordIndex);
                words.Insert(secondWordIndex, firstReplace);
            }
        }

        private static void PutWord(string word, int indexWord, List<string> words)
        {
            if (indexWord >= 0 && indexWord <= words.Count)
            {
                words.Insert(indexWord, word);
            }
        }

        private static void SwapWordsMet(string firstWord, string secondWord, List<string> words)
        {
            if (words.Contains(firstWord) && words.Contains(secondWord))
            {
                int firstWordIndex = words.IndexOf(firstWord);
                int secondWordIndex = words.IndexOf(secondWord);
                words[firstWordIndex] = secondWord;
                words[secondWordIndex] = firstWord;
            }
        }

        private static void DeleteWord(int index, List<string> words)
        {
            if (index >= 0 && index < words.Count)
            {

                words.RemoveAt(index);
            }
        }
    }
}
