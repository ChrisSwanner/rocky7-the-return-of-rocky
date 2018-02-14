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

    [HttpPost("/NewGame")]
    public ActionResult NewGame()
    {
      RockPaperScissorsGame newGame = new RockPaperScissorsGame("Rock","Scissors");
      return View(newGame);
    }
  }
}
