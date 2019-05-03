// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using WordCounter.Models;
//
//
// namespace WordCounter.Controllers
// {
//   public class LeetSpeakTranslatorsController : Controller
//   {
//     [HttpGet("/leetspeak/new")]
//     public ActionResult New()
//     {
//       return View();
//     }
//
//     [HttpGet("/leetspeak")]
//     public ActionResult Index()
//     {
//       List<CheckScore> allCheckScores = CheckScore.GetAll();
//       return View(allCheckScores);
//     }
//
//     [HttpPost("/leetspeak")]
//     public ActionResult Create(string wordInput)
//     {
//         LeetSpeakTranslator newTranslator = new LeetSpeakTranslator(wordInput);
//         newTranslator.Translate();
//         return View("Index");
//     }
//
//   }
// }
