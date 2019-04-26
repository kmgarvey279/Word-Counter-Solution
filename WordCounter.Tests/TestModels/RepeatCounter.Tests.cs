using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "The cat came back.");
      Assert.AreEqual(typeof(RepeatCounter), testRepeatCounter.GetType());  
    }
  }
}
