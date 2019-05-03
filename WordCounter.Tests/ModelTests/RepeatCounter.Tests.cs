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
    [TestMethod]
    public void CheckMatches_ReturnsMatchesForCharAndString_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("c", "cat starts with 'c'.");
      Assert.AreEqual(1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ReturnsCaseInsensitiveMatches_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("C", "Cat starts with 'C'.");
      Assert.AreEqual(1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ReturnsMatchesForStrings_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "Does the cat from 'The Cat in the Hat' have a real name?");
      Assert.AreEqual(2, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ExcludePartialMatches_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cat", "The word 'concatenate' and Catman contain the word 'cat'.");
      Assert.AreEqual(1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ExcludeNonLetterStrings_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("&&k&", "The word 'concatenate' and Catman contain the word 'cat'.");
      Assert.AreEqual(-1, testRepeatCounter.CheckMatches());
    }
    [TestMethod]
    public void CheckMatches_ExcludeWordLongerThanSentence_Int()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("concatinate", "cat");
      Assert.AreEqual(-1, testRepeatCounter.CheckMatches());
    }
  }
}
