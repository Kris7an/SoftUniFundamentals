using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(':').ToList();

            string input;
            List<string> newDeck = new List<string>();
            while ((input = Console.ReadLine()) != "Ready")
            {
                List<string> commandArg = input.Split(" ").ToList();
                string command = commandArg[0];
                switch (command)
                {
                    case "Add":
                        string word = commandArg[1];
                        AddToEnd(word, cards, newDeck);
                        break;
                    case "Insert":
                        word = commandArg[1];
                        int index = int.Parse(commandArg[2]);
                        InsertCardAt(word, index, cards, newDeck);
                        break;
                    case "Remove":
                        word = commandArg[1];
                        RemoveCard(word, newDeck);
                        break;
                    case "Swap":
                        string firstWord = commandArg[1];
                        string secondWord = commandArg[2];
                        SwapCards(firstWord, secondWord, cards, newDeck);
                        break;
                    case "Shuffle":
                        newDeck.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }

        private static void SwapCards(string firstWord, string secondWord, List<string> cards, List<string> newDeck)
        {
            if (newDeck.Contains(firstWord) && newDeck.Contains(secondWord))
            {
                int firstWordIndex = newDeck.IndexOf(firstWord);
                int secondWordIndex = newDeck.IndexOf(secondWord);
                newDeck[firstWordIndex] = secondWord;
                newDeck[secondWordIndex] = firstWord;
            }
        }

        private static void RemoveCard(string word,List<string> newDeck)
        {
            if (newDeck.Contains(word))
            {
                newDeck.Remove(word);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        private static void InsertCardAt(string word, int index, List<string> cards, List<string> newDeck)
        {
            if (cards.Contains(word) && index >= 0 && index < newDeck.Count)
            {
                newDeck.Insert(index, word);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private static void AddToEnd(string word, List<string> cards, List<string> newDeck)
        {
            if (cards.Contains(word))
            {
                newDeck.Insert(newDeck.Count, word); 
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
    }
}
