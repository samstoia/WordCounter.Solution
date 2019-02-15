using System;
using System.Collections.Generic;
// using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      int count = 0;
      Console.WriteLine("Welcome to the word counter. Enter a sentence you would like to analyze.");

      string sentence = Console.ReadLine().ToLower();
      if (sentence.Length < 1)
      {
        Console.WriteLine("Sorry, that is not an acceptable input");
        Main();
      }


      string[] sentenceArray = sentence.Split(new Char[] {' ', ',', '.' });

      Console.WriteLine("Now enter a word, and we will tell you how many times that word appeared in that senctence");

      string word = Console.ReadLine().ToLower();
      if (word.Length < 1)
      {
        Console.WriteLine("Sorry, that is not an acceptable input");
        Main();
      }


      foreach (string arrayWord in sentenceArray)
        if(arrayWord.Equals(word))
        {
          count +=1;
        }
        Console.WriteLine("This word appears " + count + " time(s) in that sentence. Would you like to analyze another sentence? [Y] for yes, [N] for no.");
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
