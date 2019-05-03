using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      RepeatCountersController controller = new RepeatCountersController();
      ActionResult indexView = controller.New();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_HasCorrectModelType_RepeatCounterList()
    {
      ViewResult indexView = new RepeatCountersController().Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
    }
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      RepeatCountersController controller = new RepeatCountersController();
      RedirectToActionResult actionResult = controller.Create("testword", "test sentence.") as RedirectToActionResult;
      string result = actionResult.ActionName;
      Assert.AreEqual(result, "Index");

    }
  }
}
