using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;
using Web.Models;

namespace RockPaperCode.Controllers
{
    public class JavaScriptCodeSamplesController : Controller
    {
        private readonly ILogger<JavaScriptCodeSamplesController> _logger;

        public JavaScriptCodeSamplesController(ILogger<JavaScriptCodeSamplesController> logger)
        {
            _logger = logger;
        }

        public IActionResult JavaScript()
        {
            return View();
        }

        public IActionResult CodeSample(string codeSample)
        {
            return PartialView(codeSample);
        }
    }
}
