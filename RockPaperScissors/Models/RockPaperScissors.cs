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
    private string _gameWinner;
    private static List<RockPaperScissorsGame> _instances = new List<RockPaperScissorsGame>{};

    public RockPaperScissorsGame (string playerOneName, string playerTwoName)
    {
      _playerOneName = playerOneName;
      _playerTwoName = playerTwoName;
      _playerOneChoice = "";
      _playerTwoChoice = "";
      _playerOneWins = 0;
      _playerTwoWins = 0;
      _draws = 0;
      _gameWinner = " ";
      _instances.Add(this);
    }

    public static List<RockPaperScissorsGame> GetAll()
    {
      return _instances;
    }

    public static void Reset()
    {
      _instances.Clear();
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

    public int GetPlayerTwoWins()
    {
      return _playerTwoWins;
    }

    public int GetDraws()
    {
      return _draws;
    }

    public string GetGameWinner()
    {
      return _gameWinner;
    }

    public void SetGameWinner(string gameWinner)
    {
      _gameWinner = gameWinner;
    }

    public int RockWinCheck()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return 0;
      }
      else if (_playerTwoChoice == "Paper")
      {
        return 2;
      }
      else
      {
        return 1;
      }
    }

    public int PaperWinCheck()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return 0;
      }
      else if (_playerTwoChoice == "Scissors")
      {
        return 2;
      }
      else
      {
        return 1;
      }
    }

    public int ScissorsWinCheck()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return 0;
      }
      else if (_playerTwoChoice == "Rock")
      {
        return 2;
      }
      else
      {
        return 1;
      }
    }

    public int GameWinCheck()
    {
      if (_playerOneChoice == "Rock")
      {
        return RockWinCheck();
      }
      else if (_playerOneChoice == "Paper")
      {
        return PaperWinCheck();
      }
      else
      {
        return ScissorsWinCheck();
      }
    }

    public void GameResult()
    {
      if (GameWinCheck() == 0)
      {
        _draws++;
        _gameWinner = "It's a Draw!";
      }
      else if (GameWinCheck() == 1)
      {
        _playerOneWins++;
        _gameWinner = _playerOneName + " Wins!";
      }
      else
      {
        _playerTwoWins++;
        _gameWinner = _playerTwoName + " Wins!";
      }
    }
  }
}
