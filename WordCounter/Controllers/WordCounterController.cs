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



// RepeatCounter newCounter = new RepeatCounter(word, sentence);
// return View(newCounter);
// }
//
// [HttpGet("/wordcounter/new")]
// public ActionResult CreateForm()
// {
// return View();
// }
// [HttpPost("/wordcounter")]
// public ActionResult Create(string word, string sentence, int count)
// {
// RepeatCounter anotherCounter = new RepeatCounter(word, sentence, count);
// return View("Index", anotherCounter);
