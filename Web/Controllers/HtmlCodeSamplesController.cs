using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;
using Web.Models;

namespace RockPaperCode.Controllers
{
    public class HtmlCodeSamplesController : Controller
    {
        private readonly ILogger<HtmlCodeSamplesController> _logger;

        public HtmlCodeSamplesController(ILogger<HtmlCodeSamplesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Html()
        {
            return View();
        }

        public IActionResult CodeSample(string codeSample) 
        { 
            return PartialView(codeSample); 
        }
    }
}
