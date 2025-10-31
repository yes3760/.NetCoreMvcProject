using Microsoft.AspNetCore.Mvc;
using CvSiteNet9_Modern.Services;
using CvSiteNet9_Modern.Models;

namespace CvSiteNet9_Modern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResumeService _resume;

        public HomeController(IResumeService resume) => _resume = resume;

        public IActionResult Index() => View(_resume.Get());
        public IActionResult Resume() => View(_resume.Get());
        public IActionResult Projects() => View(_resume.Get());
        public IActionResult Error() => View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
    }
}
