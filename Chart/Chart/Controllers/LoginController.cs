using Chart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chart.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Singin()
        {
            return View();
        }
    }
}
