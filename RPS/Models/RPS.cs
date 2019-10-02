namespace Game.Models
{
   public class Player
   {
       public string Name {get; set;}
       public string GetPlayer(string name)
       {
           Name = name; 
           return Name;
       }
   }

}