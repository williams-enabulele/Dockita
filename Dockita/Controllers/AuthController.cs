using Microsoft.AspNetCore.Mvc;

namespace Dockita.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}