using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissor.Models;
using System;

namespace RockPaperScissor.Tests
{
    [TestClass]
    public class RockPaperScissorTest
    {
        [TestMethod]
        public void Play_ReturnsPlayer1_String()
        {
            //Arrange
            string expected = "player1";
            //Act
            RockPaper rps = new RockPaper("scissors", "paper");
            string actual = rps.Play();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Play_ReturnsDraw_String()
        {
            //Arrange
            string expected = "draw";
            //Act
            RockPaper rps = new RockPaper("scissors", "scissors");
            string actual = rps.Play();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_ReturnsPlayer2_String()
        {
            //Arrange
            string expected = "player2";
            //Act
            RockPaper rps = new RockPaper("scissors", "rock");
            string actual = rps.Play();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Returns2WithRock_String()
        {
            //Arrange
            string expected = "player2";
            //Act
            RockPaper rps = new RockPaper("rock", "paper");
            string actual = rps.Play();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
