using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck mydeck = new Deck();

            // tell the deck to shuffle and print itself
            mydeck.Shuffle(); mydeck.Print();

            // take the top card from the deck and print the card rank and suit
            Card card0 = mydeck.TakeTopCard();
            Console.WriteLine(card0.Rank);
            Console.WriteLine(card0.Suit);

            // take the top card from the deck and print the card rank and suit
            Card card1 = mydeck.TakeTopCard();
            Console.WriteLine(card1.Rank);
            Console.WriteLine(card1.Suit);
        }
    }
}
