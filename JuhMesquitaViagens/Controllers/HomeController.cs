﻿using JuhMesquitaViagens.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JuhMesquitaViagens.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;      

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var destinies = _context.Destiny.ToList();
            return View(destinies);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}