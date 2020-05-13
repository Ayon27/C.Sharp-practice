using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome \n");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player

            Card[,] player = new Card[3, 2]; // each row represents a player's cards

            for (int col = 0; col < player.GetLength(1); col++) // the array fills column wise to ensure proper dealing
            {
                for (int row = 0; row < player.GetLength(0); row++)
                {
                    player[row, col] = deck.TakeTopCard();
                }
            }
            
            // flip all the cards over
            for (int row = 0; row < player.GetLength(0); row++) // cards are flipped row wise
            {
                for (int col = 0; col < player.GetLength(1); col++)
                {
                    player[row, col].FlipOver();
                }
            }

            // print the cards for player 1

            for (int row = 0; row < player.GetLength(0); row++) // all player's cards are printed
            {
                Console.WriteLine("Player " + (row + 1) + ": ");
                
                for (int col = 0; col < player.GetLength(1); col++)
                {
                    Console.WriteLine(player[row, col].Rank + " of " + player[row, col].Suit);
                }
                Console.WriteLine();
            }

            // // print the cards for player 2

            // // print the cards for player 3

        }
    }
}