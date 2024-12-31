using Microsoft.AspNetCore.Mvc;

namespace NoelBabaOyunu.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
