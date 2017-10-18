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
        return View();
      }
    }
}
