using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _count;

    public RepeatCounter(string word, string sentence)
    {
      _word = word.ToLower();
      _sentence = sentence.ToLower();
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public string SetSentence(string newSentence)
    {
      _sentence = newSentence;
      return newSentence;
    }
    public string SetWord(string newWord)
    {
      _word = newWord;
      return newWord;
    }
    public int GetCount()
    {
      _count = 0;
      string[] sentenceArray = _sentence.Split(new Char[] {' ', ',', '.', '?', '?' });
      foreach (string arrayWord in sentenceArray)
      {
        if(arrayWord.Equals(_word))
        {
          _count +=1;
        }
      }
      return _count;
    }

  }
}
