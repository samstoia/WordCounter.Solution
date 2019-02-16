using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
      [TestMethod]
      public void RepeatCounter_CreatesInstanceOfRepeatCounter_RepeatCounterNewCounter()
      {
        RepeatCounter newCounter = new RepeatCounter("test", "test");
        Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
      }
      [TestMethod]
      public void GetWord_GetsTheWord_String()
      {
        string samepleInput = "cat";
        RepeatCounter newCounter = new RepeatCounter("cat", "test");
        string result = newCounter.GetWord();
        Assert.AreEqual(samepleInput, result);
      }
      [TestMethod]
      public void GetSentence_GetsTheSentence_String()
      {
        string sampleInput = "the cat is the bomb";
        RepeatCounter newCounter = new RepeatCounter("test", "the cat is the bomb");
        string result = newCounter.GetSentence();
        Assert.AreEqual(sampleInput, result);

      }
      [TestMethod]
      public void SetSentence_SetsTheSentence_String()
      {
        string sampleInput = "the cat is the bomb";
        RepeatCounter newCounter = new RepeatCounter("test", sampleInput);
        string newInput = "the dog is the bomb";
        newCounter.SetSentence(newInput);
        string result = newCounter.GetSentence();
        Assert.AreEqual(newInput, result);
      }
      [TestMethod]
      public void SetWord_SetsWord_String()
      {
        string sampleInput = "the cat is the bomb";
        RepeatCounter newCounter = new RepeatCounter(sampleInput, "test");
        string newInput = "the dog is the bomb";
        newCounter.SetWord(newInput);
        string result = newCounter.GetWord();
        Assert.AreEqual(newInput, result);
      }
      [TestMethod]
      public void GetCount_CountsWordInSentence_Int()
      {
        RepeatCounter newCounter = new RepeatCounter("cat", "the cat is in the hat");

        int result = newCounter.GetCount();

        Assert.AreEqual(1, result);
      }
    }
  }
