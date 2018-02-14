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
    public void NewGame_HasCorrectModelType_Obj()
    {
      //arrange
      ViewResult newGameView = new HomeController().NewGame() as ViewResult;
      //act
      var result = newGameView.ViewData.Model;

      //assert
      Assert.IsInstanceOfType(result, typeof(RockPaperScissorsGame));
    }
  }
}
