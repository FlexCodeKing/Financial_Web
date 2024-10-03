using Microsoft.AspNetCore.Mvc;

namespace Chart.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
