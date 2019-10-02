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
            Player PlayerOne = new Player("Player One");
            PlayerOne.SetMove("rock");
            //Act
            string playersMove = PlayerOne.GetMove();
            //Assert
            Assert.AreEqual(playersMove, "rock");
        }
    }

}

