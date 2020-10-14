using System;
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
        private readonly CodeSharpenerContext _context;

        public HomeController(CodeSharpenerContext context)
        {
            _context = context;
        }
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
        [HttpGet("aboutme")]
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
