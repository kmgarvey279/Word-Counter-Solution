using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;


namespace WordCounter.Controllers
{
  public class CheckScoresController : Controller
  {
    [HttpGet("/scrabblescore/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/scrabblescore")]
    public ActionResult Index()
    {
      List<CheckScore> allCheckScores = CheckScore.GetAll();
      return View(allCheckScores);
    }

    [HttpPost("/scrabblescore")]
    public ActionResult Create(string wordInput)
    {
      if (wordInput != null)
      {
        CheckScore newScore = new CheckScore(wordInput);
        newScore.CalculateScore();
        List<CheckScore> allCheckScores = CheckScore.GetAll();
        return View("Index", allCheckScores);
      }
      else
      {
        return View("New");
      }
    }

  }
}
