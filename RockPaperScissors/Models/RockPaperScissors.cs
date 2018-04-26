using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace RockPaperScissors.Models
{
  public class RockPaperScissors
  {

    private string _player1Input;
    private string _player2Input;


    public Game(string player1, string player2)
    {
      _player1Input = player1;
      _player2Input = player2;
    }

    public string GetPlayer1Input()
    {
      return _player1Input;
    }

    public string GetPlayer2Input()
    {
      return _player2Input;
    }

    public string Winner()
    {
      string result = " ";
      if ((_player1Input == "rock" && _player2Input == "scissors")||(_player1Input == "paper" && _player2Input == "rock")||(_player1Input == "scissors" && _player2Input == "paper"))
      {
        return "Player One Wins.";
      }
      else if ((_player1Input == "rock" && _player2Input == "paper")||(_player1Input == "paper" && _player2Input == "scissors")||(_player1Input == "scissors" && _player2Input == "rock"))
      {
        return "Player Two wins.";
      }
      else if ((_player1Input == "rock" && _player2Input == "rock")||(_player1Input == "paper" && _player2Input == "paper")||(_player1Input == "scissors" && _player2Input == "scissors"))
      {
        return "The game is a draw, try again.";
      }
      else
      {
        return "Invalid response(s), try again.";
      }
      return result;
    }
  }
}
