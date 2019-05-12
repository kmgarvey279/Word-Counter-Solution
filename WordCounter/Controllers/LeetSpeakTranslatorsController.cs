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
      List<LeetSpeakTranslator> allLeetSpeakTranslators = LeetSpeakTranslator.GetAll();
      return View(allLeetSpeakTranslators);
    }

    [HttpPost("/leetspeak")]
    public ActionResult Create(string wordInput)
    {
      if (wordInput != null)
      {
        LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator(wordInput);
        List<LeetSpeakTranslator> allLeetSpeakTranslators = LeetSpeakTranslator.GetAll();
        return View("Index", allLeetSpeakTranslators);
      }
      else
      {
        return View("New");
      }
    }

  }
}
