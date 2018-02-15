using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTest
  {
    [TestMethod]
    public void Getters_PlayerOneNameAndGameWinner_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      string result = newGame.GetPlayerOneName();
      string gameWinnerResult = newGame.GetGameWinner();
      //assert
      Assert.AreEqual("Player 1", result);
      Assert.AreEqual(" ", gameWinnerResult);
    }

    [TestMethod]
    public void Setters_PlayerOneNameAndGameWinner_void()
    {
      //arrange
      string name = "Joel";
      string name2 = "Sara";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneName(name);
      newGame.SetGameWinner(name2);
      //assert
      Assert.AreEqual("Joel", newGame.GetPlayerOneName());
      Assert.AreEqual("Sara", newGame.GetGameWinner());
    }

    [TestMethod]
    public void GetName_FetchPlayerTwoName_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      string result = newGame.GetPlayerTwoName();
      //assert
      Assert.AreEqual("Player 2", result);
    }

    [TestMethod]
    public void SetName_SetPlayerTwoName_void()
    {
      //arrange
      string name = "Joel";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerTwoName(name);
      //assert
      Assert.AreEqual("Joel", newGame.GetPlayerTwoName());
    }

    [TestMethod]
    public void GetChoice_FetchPlayerOneChoice_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      string result = newGame.GetPlayerOneChoice();
      //assert
      Assert.AreEqual("", result);
    }

    [TestMethod]
    public void SetName_SetPlayerOneChoice_void()
    {
      //arrange
      string choice = "Paper";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice(choice);
      //assert
      Assert.AreEqual("Paper", newGame.GetPlayerOneChoice());
    }

    [TestMethod]
    public void GetChoice_FetchPlayerTwoChoice_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      string result = newGame.GetPlayerTwoChoice();
      //assert
      Assert.AreEqual("", result);
    }

    [TestMethod]
    public void SetName_SetPlayerTwoChoice_void()
    {
      //arrange
      string choice = "Paper";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerTwoChoice(choice);
      //assert
      Assert.AreEqual("Paper", newGame.GetPlayerTwoChoice());
    }

    [TestMethod]
    public void GetWins_GetPlayerOneWins_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      int result = newGame.GetPlayerOneWins();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetWins_GetPlayerTwoWins_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      int result = newGame.GetPlayerTwoWins();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetDraws_FetchDraws_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      int result = newGame.GetDraws();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void RockWinCheck_PlayerOnePicksRock_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice("Rock");
      newGame.SetPlayerTwoChoice("Scissors");
      int result = newGame.RockWinCheck();
      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void PaperWinCheck_PlayerOnePicksPaper_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice("Paper");
      newGame.SetPlayerTwoChoice("Scissors");
      int result = newGame.PaperWinCheck();
      //assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ScissorsWinCheck_PlayerOnePicksScissors_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice("Scissors");
      newGame.SetPlayerTwoChoice("Paper");
      int result = newGame.ScissorsWinCheck();
      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GameWinCheck_DetermineWinnerOrDraw_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice("Rock");
      newGame.SetPlayerTwoChoice("Scissors");
      int result = newGame.GameWinCheck();
      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GameResult_SetScores_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Player 1","Player 2");
      //act
      newGame.SetPlayerOneChoice("Scissors");
      newGame.SetPlayerTwoChoice("Paper");
      newGame.GameResult();
      string result = newGame.GetGameWinner();
      //assert
      Assert.AreEqual(1, newGame.GetPlayerOneWins());
      Assert.AreEqual(result, "Player 1 Wins!");
    }
  }
}
