using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class LeetSpeakTranslator
  {
    private string _userInput;
    private static List<LeetSpeakTranslator> _instances = new List<LeetSpeakTranslator> { };

    public LeetSpeakTranslator(string userInput)
    {
      _userInput = userInput;
      _instances.Add(this);
    }
    public string GetInput()
    {
      return _userInput;
    }
    public static List<LeetSpeakTranslator> GetAll()
    {
      return _instances;
    }

    public string Translate()
    {
      char[] myArr = _userInput.ToCharArray();
      for(int i = 0; i < myArr.Length; i++)
      {
        if(myArr[i]== 'e' || myArr[i]== 'E')
        {
          myArr[i]= '3';
        }
        else if(myArr[i] =='o' || myArr[i] =='O')
        {
          myArr[i] = '0';
        }
        else if(myArr[i] == 'I')
        {
          myArr[i] = '1';
        }
        else if(myArr[i] == 't' || myArr[i] == 'T')
        {
          myArr[i] = '7';
        }
        else if (myArr[i] == 's' && i != 0 || myArr[i] == 'S' && i != 0 )
        {
          myArr[i] = 'Z';
        }
      }
      string output = string.Join("", myArr);
      return output;
    }
  }
}
