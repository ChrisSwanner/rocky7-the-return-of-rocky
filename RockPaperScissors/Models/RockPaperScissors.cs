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

    public void SetPlayerOneName(string name)
    {
      _playerOneName = name;
    }

    public string GetPlayerTwoName()
    {
      return _playerTwoName;
    }

    public void SetPlayerTwoName(string name)
    {
      _playerTwoName = name;
    }

    public string GetPlayerOneChoice()
    {
      return _playerOneChoice;
    }

    public void SetPlayerOneChoice(string choice)
    {
      _playerOneChoice = choice;
    }

    public string GetPlayerTwoChoice()
    {
      return _playerTwoChoice;
    }

    public void SetPlayerTwoChoice(string choice)
    {
      _playerTwoChoice = choice;
    }

    public int GetPlayerOneWins()
    {
      return _playerOneWins;
    }

    public void SetPlayerOneWins()
    {
      _playerOneWins++;
    }

    public int GetPlayerTwoWins()
    {
      return _playerTwoWins;
    }

    public void SetPlayerTwoWins()
    {
      _playerTwoWins++;
    }

    public int GetDraws()
    {
      return _draws;
    }

    public void SetDraws()
    {
      _draws++;
    }
  }
}
