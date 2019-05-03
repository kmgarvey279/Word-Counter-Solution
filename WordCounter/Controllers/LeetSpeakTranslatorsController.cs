using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;


namespace WordCounter.Controllers
{
  public class LeetSpeakTranslatorsController : Controller
  {
    [HttpGet("/leetspeak/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/leetspeak")]
    public ActionResult Index()
    {
      List<CheckScore> allCheckScores = CheckScore.GetAll();
      return View(allCheckScores);
    }

    [HttpPost("/leetspeak")]
    public ActionResult Create(string wordInput)
    {
      if (wordInput != null)
      {
        LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
        newTranslator.Translate(wordInput);
        return View("Index");
      }
      else
      {
        return View("New");
      }
    }

  }
}
