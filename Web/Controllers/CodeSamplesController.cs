using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
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

        #region HTML
        public IActionResult Html()
        {
            return View();
        }

        public IActionResult HtmlCodeSample(string codeSample) 
        { 
            return PartialView(codeSample); 
        }
        #endregion

        #region JavaScript
        public IActionResult JavaScript()
        {
            return View();
        }

        public IActionResult JavaScriptCodeSample(string codeSample)
        {
            return PartialView(codeSample);
        }
        #endregion

        #region C#
        public IActionResult CSharp()
        {
            return View();
        }

        public IActionResult CSharpCodeSample(string codeSample)
        {
            return PartialView(codeSample);
        }
        #endregion
    }
}
