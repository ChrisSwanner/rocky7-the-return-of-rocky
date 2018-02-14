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
    public void GetName_FetchPlayerOneName_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      string result = newGame.GetPlayerOneName();
      //assert
      Assert.AreEqual("Player 1", result);
    }

    [TestMethod]
    public void SetName_SetPlayerOneName_void()
    {
      //arrange
      string name = "Joel";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      newGame.SetPlayerOneName(name);
      //assert
      Assert.AreEqual("Joel", newGame.GetPlayerOneName());
    }

    [TestMethod]
    public void GetName_FetchPlayerTwoName_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
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
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      newGame.SetPlayerTwoName(name);
      //assert
      Assert.AreEqual("Joel", newGame.GetPlayerTwoName());
    }

    [TestMethod]
    public void GetChoice_FetchPlayerOneChoice_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      string result = newGame.GetPlayerOneChoice();
      //assert
      Assert.AreEqual("Rock", result);
    }

    [TestMethod]
    public void SetName_SetPlayerOneChoice_void()
    {
      //arrange
      string choice = "Paper";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      newGame.SetPlayerOneChoice(choice);
      //assert
      Assert.AreEqual("Paper", newGame.GetPlayerOneChoice());
    }

    [TestMethod]
    public void GetChoice_FetchPlayerTwoChoice_String()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      string result = newGame.GetPlayerTwoChoice();
      //assert
      Assert.AreEqual("Scissors", result);
    }

    [TestMethod]
    public void SetName_SetPlayerTwoChoice_void()
    {
      //arrange
      string choice = "Paper";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      newGame.SetPlayerTwoChoice(choice);
      //assert
      Assert.AreEqual("Paper", newGame.GetPlayerTwoChoice());
    }

    [TestMethod]
    public void GetWins_GetPlayerOneWins_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      int result = newGame.GetPlayerOneWins();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SetWin_PlayerOneWins_void()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock", "Scissors");
      //act
      newGame.SetPlayerOneWins();
      //assert
      Assert.AreEqual(1, newGame.GetPlayerOneWins());
    }

    [TestMethod]
    public void GetWins_GetPlayerTwoWins_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      int result = newGame.GetPlayerTwoWins();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SetWin_PlayerTwoWins_void()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock", "Scissors");
      //act
      newGame.SetPlayerTwoWins();
      //assert
      Assert.AreEqual(1, newGame.GetPlayerTwoWins());
    }
    [TestMethod]
    public void GetDraws_FetchDraws_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      //act
      int result = newGame.GetDraws();
      //assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SetDraws_AddToDraws_void()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock", "Scissors");
      //act
      newGame.SetDraws();
      //assert
      Assert.AreEqual(1, newGame.GetDraws());
    }

    [TestMethod]
    public void DrawCheck_CheckDraw_bool()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Scissors", "Scissors");
      //act
      bool result = newGame.DrawCheck();
      //assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void RockWinCheck_PlayerOnePicksRock_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock", "Scissors");
      //act
      int result = newGame.RockWinCheck();
      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void PaperWinCheck_PlayerOnePicksPaper_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Paper", "Scissors");
      //act
      int result = newGame.PaperWinCheck();
      //assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ScissorsWinCheck_PlayerOnePicksScissors_int()
    {
      //arrange
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Scissors", "Paper");
      //act
      int result = newGame.ScissorsWinCheck();
      //assert
      Assert.AreEqual(1, result);
    }
  }
}
