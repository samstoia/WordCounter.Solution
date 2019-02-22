using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult newView = controller.New();
      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }
    [TestMethod]
    public void Create_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult newCreate = controller.Create("word", "sentence");
      Assert.IsInstanceOfType(newCreate, typeof(ViewResult));
    }
  }
}
