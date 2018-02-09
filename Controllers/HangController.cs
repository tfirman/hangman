using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hang.Models;
using System;

namespace Hang.Controllers
{
    public class HangController : Controller
    {
        [HttpGet("/hangman")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpGet("/hangman/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/hangman/new")]
        public ActionResult Create()
        {
            string stringHang = Request.Form["new-hangman"];
            Hangman.SetWord(stringHang);
            return View("Index");
        }
        [HttpPost("/hangman")]
        public ActionResult Letter()
        {
            string stringLetter = Request.Form["new-letter"];
            Hangman.Guess(stringLetter);
            return View("Index");
        }

    }
}
