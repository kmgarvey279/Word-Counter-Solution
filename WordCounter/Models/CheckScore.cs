using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

  public class CheckScore
  {
    private readonly Dictionary<char, int> ScoreGet = new Dictionary<char, int>
    {
      {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1},
      {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3},
      {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
      {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10}
    };
    private string _userInput;
    private int _userScore;
    private static List<CheckScore> _instances = new List<CheckScore> { };


    public CheckScore(string userInput)
    {
      _userInput = userInput;
      _userScore = 0;
      _instances.Add(this);
    }

    public Dictionary<char, int> GetScoreGet()
    {
      return ScoreGet;
    }

    public string GetUserInput()
    {
      return _userInput;
    }

    public int GetUserScore()
    {
      return _userScore;
    }

    public static List<CheckScore> GetAll()
    {
      return _instances;
    }
    public void CalculateScore()
    {
      string upperInput = _userInput.ToUpper();
      for(int i = 0; i < upperInput.Length; i++)
      {
        if(ScoreGet.ContainsKey(upperInput[i]))
        {
          _userScore += ScoreGet[upperInput[i]];
        }
      }
    }
  }
}
