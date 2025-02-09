using Microsoft.AspNetCore.Mvc;

namespace AspStudio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
