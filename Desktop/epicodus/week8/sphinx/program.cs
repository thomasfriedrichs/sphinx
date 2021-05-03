using System;
using Riddles.Sphinx;

namespace Riddles 
{
  class RiddleGame
  {
    static void Main()
    {
      SphinxRiddles sphinx = new SphinxRiddles();
      string userGuess = sphinx.TellRiddle();
      bool isCorrect = sphinx.CheckAnswer(userGuess);
      if (isCorrect)
      {
        Console.WriteLine("Correct! You have defeated the Sphinx!");
      } 
      else
      {
        Console.WriteLine("Incorrect! The Sphinx eats you!");
      }
      Console.WriteLine("Do you want another riddle?['Y' for yes, 'Enter' for no]");
      string Answer = Console.ReadLine();
      if (Answer == "Y" || Answer == "y")
      {
        Main();
      } else {
        Console.WriteLine("GoodBye");
      }
    }
  }
}