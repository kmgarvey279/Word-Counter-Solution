using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public int CheckMatches()
    {
      int matches = 0;
      string wordToCheck = _word.ToUpper();
      string sentenceToCheck = _sentence.ToUpper();
      for(int i = 0; i < sentenceToCheck.Length; i++)
      {
        Console.WriteLine(sentenceToCheck[i]);
        if(wordToCheck[0] == sentenceToCheck[i])
        {
          string substringToCheck = sentenceToCheck.Substring(i, wordToCheck.Length);
          if(substringToCheck == wordToCheck)
          {
            matches++;
          }
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
  }
}
