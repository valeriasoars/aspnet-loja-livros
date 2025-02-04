using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LojaLivrosASPNET.Models
{
    public class LivroModel
    {
        public int Id { get; set; } 
        public string Titulo { get; set; } 
        public string Autor { get; set; } 
        public string Editora { get; set; } 
        public string ImagemLivro { get; set; }
        public DateTime DataPublicacao { get; set; } 
        public string ISBN { get; set; } 
        public decimal Preco { get; set; } 
        public int NumeroPaginas { get; set; } 
        public string Descricao { get; set; } 
        public int QuantidadeEstoque { get; set; }
        public int CategoriaModelId { get; set; }

        [ValidateNever]
        public CategoriaModel Categoria { get; set; }
    }
}
