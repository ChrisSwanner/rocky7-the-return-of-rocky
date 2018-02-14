using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace RockPaperScissors.Models
{
  public class RockPaperScissorsGame
  {
    private string _playerOneName;
    private string _playerTwoName;
    private string _playerOneChoice;
    private string _playerTwoChoice;
    private int _playerOneWins;
    private int _playerTwoWins;
    private int _draws;

    public RockPaperScissorsGame (string playerOneChoice, string playerTwoChoice)
    {
      _playerOneName = "Player 1";
      _playerTwoName = "Player 2";
      _playerOneChoice = playerOneChoice;
      _playerTwoChoice = playerTwoChoice;
      _playerOneWins = 0;
      _playerTwoWins = 0;
      _draws = 0;
    }

    public string GetPlayerOneName()
    {
      return _playerOneName;
    }

    public string GetPlayerTwoName()
    {
      return _playerTwoName;
    }
  }
}
