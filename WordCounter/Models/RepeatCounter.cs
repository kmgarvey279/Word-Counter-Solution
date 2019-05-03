using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private static List<RepeatCounter> _instances = new List<RepeatCounter> { };

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      _instances.Add(this);
    }

    public int CheckMatches()
    {
      int matches = 0;
      string wordToCheck = _word.ToUpper();
      string[] sentenceToCheck = _sentence.ToUpper().Split(' ');
      foreach (string splitWord in sentenceToCheck)
      {
        if (wordToCheck == splitWord)
        {
          matches++;
        }
      }
      return matches;
    }

    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }

    public static List<RepeatCounter> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
