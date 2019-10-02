using System;
using Game.Models;

namespace RPS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Would you like to play rock, paper, scissors? [Y/N]");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                GamePlay();
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        
         void GamePlay()
        {
            Console.WriteLine("Player One, enter your name!");
            string userNameOne = Console.ReadLine();
            Player playerOne = new Player(userNameOne);

            Console.WriteLine("Choose: Rock, Paper, Scissors [rock/paper/scissors]");
            string userChoiceOne = Console.ReadLine();
            playerOne.SetMove(userChoiceOne);

            Console.WriteLine("Player Two, enter your name!");
            string userNameTwo = Console.ReadLine();
            Player playerTwo = new Player(userNameTwo);
            
            Console.WriteLine("Choose: Rock, Paper, Scissors [rock/paper/scissors]");
            string userChoiceTwo = Console.ReadLine();
            playerTwo.SetMove(userChoiceTwo);

            Console.WriteLine(playerOne.Winner(playerTwo));
        }

        }
    }
    
}
