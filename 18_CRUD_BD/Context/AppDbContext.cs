using Microsoft.EntityFrameworkCore;
using  _18_crud_bancoDados.Models;

namespace _18_crud_bancoDados.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<jogo> Jogos {get; set;}
    }
}