using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View(PortfolioData.Projects);
        }
    }
}