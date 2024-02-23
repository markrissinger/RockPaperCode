using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace RockPaperCode.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ILogger<AboutMeController> _logger;

        public AboutMeController(ILogger<AboutMeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
