using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Replace.Models;

namespace Replace.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View("Index", WordReplacer.LastOutput);
      }

      [HttpPost("/result")]
      public ActionResult Result()
      {
        string sentence = Request.Form["sentence"];
        string replacedWord = Request.Form["replaced-word"];
        string newWord = Request.Form["new-word"];
        WordReplacer.Replace(sentence, replacedWord, newWord);
        return Redirect("/");
      }
    }
}
