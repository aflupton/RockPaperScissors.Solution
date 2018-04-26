using System;
using System.Collections.Generic;
using RockPaperScissorsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace RockPaperScissorsApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/Game")]
    public ActionResult CheckWin()
    {
      string p1 = Request.Form["player1"];
      string p2 = Request.Form["player2"];
      RockPaperScissors inputs = new RockPaperScissors(p1, p2);
      string winner = inputs.Winner();
      Console.WriteLine(winner);
      return View("Result", winner);
    }
  }
}
