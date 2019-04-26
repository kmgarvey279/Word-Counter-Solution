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
    [TestMethod]
    public void CheckMatches_ReturnsMatchForChar_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c", "c");
      Assert.AreEqual(1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ReturnsNoMatchForChar_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c", "d");
      Assert.AreEqual(0, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ReturnsMatchForString_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "cat");
      Assert.AreEqual(1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ReturnsNoMatchForString_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "dog");
      Assert.AreEqual(0, testRepeatCounter.CheckMatches());
    }
  }
}
