using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCneelam.Models;
using System.Diagnostics;
using System.Linq;

namespace MVCneelam.Controllers
{
    public class HomeController : Controller
    {
        private readonly Author _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(Author dbContext, ILogger<HomeController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var authors = _dbContext.Author.ToString();
            return View();
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
