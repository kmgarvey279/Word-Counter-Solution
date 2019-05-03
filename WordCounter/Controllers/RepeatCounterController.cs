using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
    [HttpGet("/repeatcounters/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/repeatcounters")]
    public ActionResult Index()
    {
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
      return View(allRepeatCounters);
    }

    [HttpPost("/repeatcounters")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
      RepeatCounter newCounter = new RepeatCounter(wordInput, sentenceInput);
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
      return View("Index", allRepeatCounters);
    }

  }
}
