using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the word counter. Enter a sentence you would like to analyze.");
      string sentence = Console.ReadLine();
      Console.WriteLine("Now enter a word, and we will tell you how many times that word appeared in that senctence");
      string word = Console.ReadLine();
      if (word.Length < 1 || sentence.Length < 1)
      {
        Console.WriteLine("Sorry, something went wrong.  Check your inputs and try again");
        Main();
      }
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      Console.WriteLine("This word appears " + newCounter.GetCount() + " time(s) in that sentence.");

      Console.WriteLine("Would you like to analyze another sentence? [Y] for yes, [N] for no.");
      string answer = Console.ReadLine().ToUpper();
      if(answer == "Y")
      {
        Main();
      }
      else if(answer == "N")
      {
        Environment.Exit(0);
      }
    }
  }
}
