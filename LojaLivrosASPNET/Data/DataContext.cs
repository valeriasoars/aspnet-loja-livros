using Microsoft.EntityFrameworkCore;

namespace LojaLivrosASPNET.Data
{
    // meio de campo entre o sql e o c#
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }



    }
}
