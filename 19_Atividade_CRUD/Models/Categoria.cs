using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _19_Atividade_CRUD_BD.Models
{
//Mapeamento com o nome que será criado na tabela
[Table("Categorias")]
public class Categoria
{
[Key]
public int CategoriaId { get; set; }
public string CategoriaNome { get; set; }
public string Descricao { get; set; }
public List<Jogo> Jogos { get; set; }
}
}