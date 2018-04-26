using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsApp.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsApp.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {

    [TestMethod]
    public void Winner_Values_ReturnP1Win1()
    {
      string dummyResult1 = "Player One Wins.";
      RockPaperScissors inputs = new RockPaperScissors("scissors", "paper");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult1, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP1WIn2()
    {
      string dummyResult1 = "Player One Wins.";
      RockPaperScissors inputs = new RockPaperScissors("paper", "rock");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult1, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP1Win3()
    {
      string dummyResult1 = "Player One Wins.";
      RockPaperScissors inputs = new RockPaperScissors("rock", "scissors");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult1, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP2Win1()
    {
      string dummyResult2 = "Player Two Wins.";
      RockPaperScissors inputs = new RockPaperScissors("rock", "paper");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult2, winner);
    }
    [TestMethod]
    public void Winner_Values_ReturnP2Win2()
    {
      string dummyResult2 = "Player Two Wins.";
      RockPaperScissors inputs = new RockPaperScissors("paper", "scissors");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult2, winner);
    }
    [TestMethod]
    public void Winner_Values_ReturnP2Win3()
    {
      string dummyResult2 = "Player Two Wins.";
      RockPaperScissors inputs = new RockPaperScissors("scissors", "rock");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult2, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnDraw1()
    {
      string dummyResult3 = "The game is a draw, try again.";
      RockPaperScissors inputs = new RockPaperScissors("paper", "paper");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult3, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnDraw2()
    {
      string dummyResult3 = "The game is a draw, try again.";
      RockPaperScissors inputs = new RockPaperScissors("rock", "rock");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult3, winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnDraw3()
    {
      string dummyResult3 = "The game is a draw, try again.";
      RockPaperScissors inputs = new RockPaperScissors("scissors", "scissors");
      string winner = inputs.Winner();
      Assert.AreEqual(dummyResult3, winner);
    }
  }
}
