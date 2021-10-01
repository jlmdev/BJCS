using System;
using System.Collections.Generic;
using System.Linq;

namespace BJCS
{
  // class Card 
  // {
  //   // Card Properties an Methods
  //   public string Suit {get; set;}
  //   public string Face {get; set;}
  //   public int Value()
  //   {
  //     switch (Face)
  //     {
  //       case "A":
  //         return 11;
  //       case "2":
  //         return 2;
  //       case "3":
  //         return 3;
  //       case "4":
  //         return 4;
  //       case "5":
  //         return 5;
  //       case "6":
  //         return 6;
  //       case "7":
  //         return 7;
  //       case "8":
  //         return 8;
  //       case "9":
  //         return 9;
  //       case "10":
  //         return 10;
  //       case "J":
  //         return 10;
  //       case "Q":
  //         return 10;
  //       case "K":
  //         return 10;
  //       default:
  //         break;
  //     }
      
  //   }
  // }

  // public class Player
  // {
  //   public string PlayerName { get; set; }
  //   public List<Card> Hand { get; set; }
  //   public int HandValue()
  //   {
  //     int handTotal = 0;
  //     foreach (Card cardInHand in Hand)
  //     {
  //       handTotal = handTotal + cardInHand.Value();
  //     }
  //     return handTotal;
  //   }
    
  // }

  class Program
  {
    static void Main(string[] args)
    {
      // Prompt player for name
      Console.WriteLine("Welcome. What's your name?");

      // Play loop
      var playAgain = true;

      while (playAgain)
      {
        // Create Deck

        // Suit Loop

        // Face Loop

        // Create Card and add to Deck

        // Shuffle Algorithm

        // Declare Variables

        // Shuffle Loop

        // Create Dealer Player Instance

        // Create human Player Instance

        // Deal initial cards to Dealer and human player

        // Player Choice Loop

        // Declare Variables

        // While loop

        // Show Player Hand (Cards and Value)

        // Check for Bust

        // Play Player Hand

        // Play Dealer Hand Loop

        // Show Dealer Cards

        // Check for bust or stand conditions Player > 21 or Dealer > 16

        // Draw card

        // Calculate Winner

        // Check Dealer Bust

        // Check Player Win

        // Dealer wins otherwise

        // Prompt to play again
        System.Console.WriteLine($"Would you like to play again? (y/n)");
        var playAgainResponse = Console.ReadLine();
        if (playAgainResponse == "n") 
        {
          playAgain = false;
        }
      }
      


    }
  }
}
