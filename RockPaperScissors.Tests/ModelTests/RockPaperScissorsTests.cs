using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {

    [TestMethod]
    public void Winner_Values_ReturnP1()
    {
      Game inputs = new Game("scissors", "paper");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player One Wins", winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP1()
    {
      Game inputs = new Game("paper", "rock");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player One Wins", winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP1()
    {
      Game inputs = new Game("rock", "scissors");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player One Wins", winner);
    }

    [TestMethod]
    public void Winner_Values_ReturnP2()
    {
      Game inputs = new Game("rock", "paper");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player Two Wins", winner);
    }
    [TestMethod]
    public void Winner_Values_ReturnP2()
    {
      Game inputs = new Game("paper", "scissors");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player Two Wins", winner);
    }
    [TestMethod]
    public void Winner_Values_ReturnP2()
    {
      Game inputs = new Game("scissors", "rock");
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("Player Two Wins", winner);
    }

    [TestMethod]
    public void Winner_Values_RockPaperScissors()
    {
      Game inputs = new Game("paper", "paper");
      string inputs = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("The game is a draw, play again.");
    }

    [TestMethod]
    public void Winner_Values_ReturnDraw()
    {
      Game inputs = new Game("rock", "rock");
      string inputs = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("The game is a draw, play again.");
    }

    [TestMethod]
    public void Winner_Values_ReturnDraw()
    {
      Game inputs = new Game("scissors", "scissors");
      string inputs = inputs.Winner();
      Console.WriteLine(winner);
      Assert.AreEqual("The game is a draw, play again.");
    }
  }
}
