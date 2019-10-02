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
                Player PlayerOne = new Player();
              
                //Act
                string playerName= PlayerOne.GetPlayer("Peter");
                //Assert
                Assert.AreEqual(playerName, "Peter" );
        }       
    }

}

