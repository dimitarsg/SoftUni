using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayerDeck = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int smallestDeckCount = firstPlayerDeck.Count;
            List<int> winningDeck = new List<int>();
            string winningPlayer = string.Empty;

            while (smallestDeckCount != 0)
            {
                    int firstPlayerCurrentCard = firstPlayerDeck[0];
                    int secondPlayerCurrentCard = secondPlayerDeck[0];

                    if (firstPlayerCurrentCard > secondPlayerCurrentCard)
                    {
                        firstPlayerDeck.Add(secondPlayerCurrentCard);
                        firstPlayerDeck.Add(firstPlayerCurrentCard);
                        firstPlayerDeck.RemoveAt(0);
                        secondPlayerDeck.RemoveAt(0);
                    }

                    if (firstPlayerCurrentCard < secondPlayerCurrentCard)
                    {
                        secondPlayerDeck.Add(firstPlayerCurrentCard);
                        secondPlayerDeck.Add(secondPlayerCurrentCard);
                        firstPlayerDeck.RemoveAt(0);
                        secondPlayerDeck.RemoveAt(0);
                    }

                    if (firstPlayerCurrentCard == secondPlayerCurrentCard)
                    {
                        firstPlayerDeck.RemoveAt(0);
                        secondPlayerDeck.RemoveAt(0);
                    }

                    smallestDeckCount = Math.Min(firstPlayerDeck.Count, secondPlayerDeck.Count);
            }

            if (firstPlayerDeck.Count > secondPlayerDeck.Count)
            {
                winningDeck = firstPlayerDeck;
                winningPlayer = "First player";
            }
            else
            {
                winningDeck = secondPlayerDeck;
                winningPlayer = "Second player";
            }

            Console.WriteLine($"{winningPlayer} wins! Sum: {winningDeck.Sum()}");
        }
    }
}
