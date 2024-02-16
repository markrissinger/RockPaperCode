using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace RockPaperCode.Controllers
{
    public class CodeSamplesController : Controller
    {
        private readonly ILogger<CodeSamplesController> _logger;

        public CodeSamplesController(ILogger<CodeSamplesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Html()
        {
            return View();
        }

        public IActionResult JavaScript()
        {
            return View();
        }

        public IActionResult CSharp()
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
