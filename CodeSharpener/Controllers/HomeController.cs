﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeSharpener.Models;

namespace CodeSharpener.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet("signin")]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpGet("codechallenges")]
        public IActionResult CodeChallenges()
        {
            return View();
        }
        [HttpGet("videoexplanations")]
        public IActionResult VideoExplanations()
        {
            return View();
        }
        [HttpGet("datastructures")]
        public IActionResult DataStructures()
        {
            return View();
        }
        [HttpGet("solutions")]
        public IActionResult Solutions()
        {
            return View();
        }
        [HttpGet("codeeditor")]
        public IActionResult CodeEditor()
        {
            return View();
        }
        [HttpGet("bigo")]
        public IActionResult BigO()
        {
            return View();
        }
    }
}
