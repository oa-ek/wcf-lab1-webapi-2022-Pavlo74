using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository.Repositories;
using RozkladSchool.Models;
using System.Diagnostics;

namespace RozkladSchool.Controllers
{
    public class WeekController : Controller
    {
        private readonly ILogger<WeekController> _logger;
        private readonly WeekRepository _weekRepository;
        public WeekController(ILogger<WeekController> logger, WeekRepository weekRepository)
        {
            _logger = logger;
            _weekRepository = weekRepository;
        }

        public IActionResult Index()
        {
            return View(_weekRepository.GetWeeks());
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
