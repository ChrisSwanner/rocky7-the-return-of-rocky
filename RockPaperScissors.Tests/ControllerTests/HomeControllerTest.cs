using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaperScissors.Controllers;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();

      //act
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;

      //assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void PlayAgain_HasCorrectModelType_RPSGame()
    {
      //arrange
      RockPaperScissorsGame dummyGame = new RockPaperScissorsGame("PlayerOneName", "PlayerTwoName");
      ViewResult playAgainView = new HomeController().PlayAgain() as ViewResult;
      //act
      var result = playAgainView.ViewData.Model;
      System.Console.WriteLine("play again result: "+result);

      //assert
      Assert.IsInstanceOfType(result, typeof(RockPaperScissorsGame));
    }

    // [TestMethod]
    // public void PlayerOneSelection_HasCorrectModelType_RPSGame()
    // {
    // //arrange
    // ViewResult PlayerOneSelectionView = new HomeController().PlayerOneSelection() as ViewResult;
    // //act
    // var result = PlayerOneSelectionView.ViewData.Model;
    // System.Console.WriteLine("result: "+result);
    // //assert
    // Assert.IsInstanceOfType(result, typeof(RockPaperScissorsGame));
    // }
  }
}
