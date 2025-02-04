using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace LojaLivrosASPNET.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

  
    }
}
