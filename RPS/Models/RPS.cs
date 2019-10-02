using System.Collections.Generic;
using System;
namespace Game.Models
{
   public class Player
   {
       public string Name {get; set;}
       public string Move {get;set;}

       public Dictionary<string,string> rps = new Dictionary<string, string>(){{"rock","scissors"},{"paper", "rock"},{"scissors", "paper"}};

       public Player(string name)
       {
           Name = name;
       }       
       public string GetPlayer()
       {
           return Name;
       }
       
       public bool SetMove(string move){
           Move = move;
           return true;
       }
       public string GetMove()
       {
           return Move;
       }

       public string Winner(Player player2)
       {
           if(Move == player2.GetMove())
           {
               return "It's a draw!";
           }
           else if (rps[Move] == player2.GetMove())
           {
               return Name + " wins!";
           }
           else
           {
               return player2.Name+ " wins!";
           }
       }

      
   }

}