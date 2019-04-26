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
      foreach (char letter in _word)
      {
        if (!Char.IsLetter(letter))
        {
          return -1;
        }
      }
      string wordToCheck = _word.ToUpper();
      string sentenceToCheck = _sentence.ToUpper();
      if(wordToCheck.Length > sentenceToCheck.Length)
      {
        return -1;
      }
      else if(wordToCheck.Length == sentenceToCheck.Length)
      {
        if(wordToCheck == sentenceToCheck)
        {
          return 1;
        }
        else
        {
          return 0;
        }
      }
      else
      {
        for(int i = 0; i < sentenceToCheck.Length; i++)
        {
          if (wordToCheck[0] == sentenceToCheck[i])
          {
            if(i == 0)
            {
              string substringToCheck = sentenceToCheck.Substring(i, wordToCheck.Length);
              if(substringToCheck == wordToCheck && !Char.IsLetter(sentenceToCheck[i+substringToCheck.Length]))
              {
                matches++;
              }
            }
            else if (!Char.IsLetter(sentenceToCheck[i-1]))
            {
              string substringToCheck = sentenceToCheck.Substring(i, wordToCheck.Length);
              if(substringToCheck == wordToCheck && !Char.IsLetter(sentenceToCheck[i+substringToCheck.Length]))
              {
                matches++;
              }
            }
          }
        }
        return matches;
      }
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
