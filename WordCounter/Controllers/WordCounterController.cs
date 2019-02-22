using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/wordcounter/create")]
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      newCounter?.GetCount();
      return View(newCounter);
    }

  }
}
