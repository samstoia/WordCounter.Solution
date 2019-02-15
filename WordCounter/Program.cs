using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      int count = 0;
      Console.WriteLine("Welcome to the word counter. Enter a sentence you would like to analyze.");

      string sentence = Console.ReadLine().ToLower();

      string[] sentenceArray = sentence.Split(new Char[] {' ', ',', '.' });

      Console.WriteLine("Now enter a word, and we will tell you how many times that word appeared in that senctence");

      string word = Console.ReadLine().ToLower();

      foreach (string arrayWord in sentenceArray)
        if(arrayWord.Equals(word))
        {
          count +=1;
        }
        Console.WriteLine("This word appears " + count + " time(s) in that sentence");
    }
  }
}
