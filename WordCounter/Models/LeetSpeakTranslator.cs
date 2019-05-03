using System;
using System.Collections.Generic;

namespace WordCounter.Models;
{
  public class LeetSpeakTranslator
  {
    private string _userInput;
    private string _output;

    public LeetSpeakTranslator(userInput)
    {
      _userInput = userInput;
    }
    public string GetInput()
    {
      return _userInput;
    }
    public string GetOutput()
    {
      return string _output;
    }

    public string Translate(string userInput)
    {
      char[] myArr = userInput.ToCharArray();
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
        // else if(myArr[i] == 's' && myArr[i] >= 'A' && myArr[i] <= 'Z' && myArr[i] >= 'a' && myArr[i] <= 'z')
        {
          myArr[i] = 'Z';
        }
      }
      _output = string.Join("", myArr);
    }
  }
}
