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
    [TestMethod]
    public void GetWord_ReturnsInputtedWord_String()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "The cat came back.");
      Assert.AreEqual("cat", testRepeatCounter.GetWord());
    }
    [TestMethod]
    public void GetSentence_ReturnsInputtedSentence_String()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "The cat came back.");
      Assert.AreEqual("The cat came back.", testRepeatCounter.GetSentence());
    }
  }
}
