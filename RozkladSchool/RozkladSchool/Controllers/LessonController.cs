﻿using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILogger<LessonController> _logger;
        private readonly LessonRepository _lessonRepository;
        public LessonController(ILogger<LessonController> logger, LessonRepository lessonRepository)
        {
            _logger = logger;
            _lessonRepository = lessonRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _lessonRepository.GetLessonAsync());
        }


        public IActionResult Privacy()
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