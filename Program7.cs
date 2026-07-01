using System;
using System.Security.Cryptography;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die();
            Die die2 = new Die();

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();

            int die1Value = die1.TopSide;
            int die2Value = die2.TopSide;

            int sum = die1Value + die2Value;

            // print the top sides and the sum of the dice
            Console.WriteLine(die1Value);
            Console.WriteLine(die2Value);
            Console.WriteLine(sum);
        }

        
    }
    
}
