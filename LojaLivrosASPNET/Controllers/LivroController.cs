using LojaLivrosASPNET.Services.Livro;
using Microsoft.AspNetCore.Mvc;

namespace LojaLivrosASPNET.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivro _livroInterface;
        public LivroController(ILivro livroInterface)
        {
            _livroInterface = livroInterface;
        }
        public async Task<IActionResult> Index()
        {
            var livros = await _livroInterface.BuscarLivros();
            return View(livros);
        }
    }
}
