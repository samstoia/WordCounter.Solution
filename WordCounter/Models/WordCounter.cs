using System;

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
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public bool IsValidInput(string input)
    {
      if(input.Length > 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
