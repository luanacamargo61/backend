using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD_BD.Models;
namespace _19_Atividade_CRUD_BD.Context
{
public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}
//No meu DbSet carregará todos os jogos salvos no banco de dados
public DbSet<Jogo> Jogos {get; set;}
public DbSet<Categoria> Categorias {get; set;}
}
}