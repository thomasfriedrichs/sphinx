using System;
using System.Collections.Generic;

namespace Riddles.Sphinx
{
  public class SphinxRiddles
  {
    private static Dictionary<int, Dictionary<string, string>> _riddleDictionary = new Dictionary<int, Dictionary<string, string>>(){
      { 1,
        new Dictionary<string,string>
        {
          {"riddle","Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name." },
          {"answer", "death"}
        }
      },
      { 2,
        new Dictionary<string, string>
        {
          {"riddle", "What can bring back the dead; make you cry, make you laugh, make you young; is born in an instant, yet lasts a lifetime."},
          {"answer", "memory"}
        }
      },
      { 3,
        new Dictionary<string, string>
        {
          {"riddle", "At night they come without being fetched, and by day they are lost without being stolen."},
          {"answer", "stars"}
        }
      }
    };

    private int _currentRiddleIndex;

    private Dictionary<string, string> Randomizer()
    { 
      Random rnd = new Random();
      int dictionaryIndex = rnd.Next(1,4);
      Dictionary<string, string> riddle = _riddleDictionary[dictionaryIndex];

      _currentRiddleIndex = dictionaryIndex;
      return riddle;
    }

    public string TellRiddle()
    {
      Dictionary<string, string> riddleDisplay = Randomizer();
      Console.WriteLine(riddleDisplay["riddle"]);
      Console.WriteLine("Please input your guess:");
      string userInput = Console.ReadLine();
      return userInput;
    }

    public bool CheckAnswer(string answerGuess)
    {
      string actualAnswer = _riddleDictionary[_currentRiddleIndex]["answer"];
      if(answerGuess.ToLower() == actualAnswer)
      {
        return true;
      } else {
        return false;
      }
    }
  }
}