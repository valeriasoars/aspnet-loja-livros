using Microsoft.AspNetCore.Mvc;

namespace LojaLivrosASPNET.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
