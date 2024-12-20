using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;
using Web.Models;

namespace RockPaperCode.Controllers
{
    public class CSharpCodeSamplesController : Controller
    {
        private readonly ILogger<CSharpCodeSamplesController> _logger;

        public CSharpCodeSamplesController(ILogger<CSharpCodeSamplesController> logger)
        {
            _logger = logger;
        }

        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult CodeSample(string codeSample)
        {
            return PartialView(codeSample);
        }
    }
}
