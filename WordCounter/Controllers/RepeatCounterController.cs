using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("/repeatcounters/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
