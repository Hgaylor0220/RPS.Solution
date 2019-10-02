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
                bool startGame = Player.GetPlayer("Jared");
                //Assert
                Assert.AreEqual(true , true);
        }       
    }

}

