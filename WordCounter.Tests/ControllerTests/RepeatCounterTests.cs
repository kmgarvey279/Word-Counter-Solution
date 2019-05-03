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
      RepeatCounterController controller = new RepeatCounterController();
      ActionResult indexView = controller.New();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_HasCorrectModelType_RepeatCounterList()
    {
      ViewResult indexView = new RepeatCounterController().Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
    }
  }
}
