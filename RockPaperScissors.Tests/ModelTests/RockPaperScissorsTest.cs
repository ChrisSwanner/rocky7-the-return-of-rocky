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
  }
}
