using LojaLivrosASPNET.Data;
using LojaLivrosASPNET.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LojaLivrosASPNET.Services.Livro
{
    public class LivroService : ILivro
    {
        private readonly DataContext _context;
        public LivroService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<LivroModel>> BuscarLivros()
        {
            try
            {
                return await _context.Livros.Include(c => c.Categoria).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
