using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Tests
{
    [TestClass]
    public class RPSTests
    {
        [TestMethod]
        public void Player_IsThereAPlayer_PlayerBool()
        {
                //Arrange
                Player PlayerOne = new Player("Peter");
              
                //Act
                string playerName= PlayerOne.GetPlayer();
                //Assert
                Assert.AreEqual(playerName, "Peter" );
        }
        [TestMethod]
        public void GetMove_UserPicksRock_Rock()
        {
            //Arrange
            Player PlayerTwo = new Player("Player One");
            PlayerTwo.SetMove("rock");
            //Act
            string playersMove = PlayerTwo.GetMove();
            //Assert
            Assert.AreEqual(playersMove, "rock");
        }
        [TestMethod]
        public void Winner_Player1RockPlayer2Scissors_Player1Winner()
        {
            //Arrange
            Player PlayerThree = new Player("Player One");
            Player PlayerFour = new Player("Player Two");
            PlayerThree.SetMove("rock");
            PlayerFour.SetMove("scissors");
            //Act
            string winner = PlayerThree.Winner(PlayerFour);
            //Assert
            Assert.AreEqual(winner, "Player 1 wins!");
        }

        [TestMethod]
        public void Winner_Player1RockPlayer2Rock_Draw()
        {
            //Arrange
            Player PlayerFive = new Player("Player One");
            Player PlayerSix = new Player("Player Two");
            PlayerFive.SetMove("rock");
            PlayerSix.SetMove("rock");
            //Act
            string winner = PlayerFive.Winner(PlayerSix);
            //Assert
            Assert.AreEqual(winner, "It's a draw!");
        }
        [TestMethod]
        public void Winner_Player1PaperPlayer2Scissors_Player2Winner()
        {
            //Arrange
            Player PlayerSeven = new Player("Player One");
            Player PlayerEight = new Player("Player Two");
            PlayerSeven.SetMove("paper");
            PlayerEight.SetMove("scissors");
            //Act
            string winner = PlayerSeven.Winner(PlayerEight);
            //Assert
            Assert.AreEqual(winner, "Player 2 wins!");
        }
    }

}

