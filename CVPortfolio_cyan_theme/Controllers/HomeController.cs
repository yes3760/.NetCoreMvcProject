using Microsoft.AspNetCore.Mvc;
using CVPortfolio.Services;

namespace CVPortfolio.Controllers;

public class HomeController : Controller
{
    private readonly CVService _cvService;
    
    public HomeController(CVService cvService)
    {
        _cvService = cvService;
    }
    
    public IActionResult Index()
    {
        var cv = _cvService.GetCV();
        return View(cv);
    }
}
