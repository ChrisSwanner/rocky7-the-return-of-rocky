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

    [HttpGet("/Reset")]
    public ActionResult Reset()
    {
      RockPaperScissorsGame.Reset();
      return View("Index");
    }

    [HttpGet("/PlayAgain")]
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

    [HttpPost("/Computer")]
    public ActionResult Computer()
    {
      string PlayerOneName = Request.Form["player-one-computer"];
      string PlayerTwoName = "Computer";
      RockPaperScissorsGame newGame = new RockPaperScissorsGame(PlayerOneName, PlayerTwoName);
      newGame.Computery();
      return View(newGame);
    }

    [HttpPost("/ComputerResults")]
    public ActionResult ComputerResults()
    {
      string PlayerOneSelection = Request.Form["player-one-selection-computer"];
      List<RockPaperScissorsGame> allGames = RockPaperScissorsGame.GetAll();
      RockPaperScissorsGame currentGame = allGames[0];
      currentGame.SetPlayerOneChoice(PlayerOneSelection);
      currentGame.GameResult();
      return View(currentGame);
    }

    [HttpGet("/PlayAgainComputer")]
    public ActionResult PlayAgainComputer()
    {
      List<RockPaperScissorsGame> allGames = RockPaperScissorsGame.GetAll();
      RockPaperScissorsGame currentGame = allGames[0];
      currentGame.Computery();
      return View("Computer", currentGame);
    }
  }
}
