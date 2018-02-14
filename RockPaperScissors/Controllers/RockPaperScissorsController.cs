using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
  public class RockPaperScissorsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult Display()
    {

      return View();
    }

  }
}
