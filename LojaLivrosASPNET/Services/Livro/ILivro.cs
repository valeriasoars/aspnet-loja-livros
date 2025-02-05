using LojaLivrosASPNET.Models;

namespace LojaLivrosASPNET.Services.Livro
{
    public interface ILivro
    {
        Task<List<LivroModel>> BuscarLivros();
    }
}
