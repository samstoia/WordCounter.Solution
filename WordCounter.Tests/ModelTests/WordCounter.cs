using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
      public void IsValidInput_IsNotBlank_True()
    {
      RepeatCounter wordCounterTest = new RepeatCounter();
      Assert.AreEqual(true, wordCounterTest.IsValidInput("hello"));
    }
    [TestMethod]
    {
      public void SetWordSentence_SettersWork_True()
      {
        //arrange
        string word;
        string sentence ;
        RepeatCounter wordCounterTest = new RepeatCounter(word, sentence);

        //act
        string word = "cat";
        wordCounterTest.SetWord(word);
        string sentence = "cat";
        wordCounterTest.SetSentence(sentence);
        string result1 = wordCounterTest.GetWord();
        string result2 = wordCounterTest.GetSentence();
        //
        Assert.AreEqual(result1, result2)
      }
    }
  }
}
