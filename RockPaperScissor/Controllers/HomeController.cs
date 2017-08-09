using Microsoft.AspNetCore.Mvc;
using RockPaperScissor.Models;
using System.Collections.Generic;
using System;

namespace RockPaperScissor.Controllers
{
  public class HomeController : Controller
  {
     [HttpGet("/")]
     public ActionResult Index()
     {
       return View();
     }

     [HttpPost("/rockPaper")]
     public ActionResult Results()
     {
       Console.WriteLine("hi");
       string player1 = Request.Form["player1"];
       string player2 = Request.Form["player2"];
       RockPaper rps = new RockPaper(player1, player2);
       return View(rps);
     }
  }
}
