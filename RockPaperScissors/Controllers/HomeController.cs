using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/PlayAgain")]
    public ActionResult PlayAgain()
    {
      List<RockPaperScissorsGame> allGames = RockPaperScissorsGame.GetAll();
      RockPaperScissorsGame currentGame = allGames[0];
      return View("PlayerOneSelection", currentGame);
    }

    [HttpPost("/PlayerOneSelection")]
    public ActionResult PlayerOneSelection()
    {
      string PlayerOneName = Request.Form["player-one"];
      string PlayerTwoName = Request.Form["player-two"];
      RockPaperScissorsGame newGame = new RockPaperScissorsGame(PlayerOneName, PlayerTwoName);

      return View(newGame);
    }

    [HttpPost("/PlayerTwoSelection")]
    public ActionResult PlayerTwoSelection()
    {
      string PlayerOneSelection = Request.Form["player-one-selection"];
      List<RockPaperScissorsGame> allGames = RockPaperScissorsGame.GetAll();
      RockPaperScissorsGame currentGame = allGames[0];
      currentGame.SetPlayerOneChoice(PlayerOneSelection);

      return View(currentGame);
    }

    [HttpPost("/Results")]
    public ActionResult Results()
    {
      string PlayerTwoSelection = Request.Form["player-two-selection"];
      List<RockPaperScissorsGame> allGames = RockPaperScissorsGame.GetAll();
      RockPaperScissorsGame currentGame = allGames[0];
      currentGame.SetPlayerTwoChoice(PlayerTwoSelection);
      currentGame.GameResult();

      return View(currentGame);
    }
  }
}
