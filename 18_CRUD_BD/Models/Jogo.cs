using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_crud_bancoDados.Models

{
    [Table("jogos")]
    public class jogo
    {
        [Key]
      public int JogoId { get; set; }
      [Required(ErrorMessage="Nome é obrigatorio")]
      [Display(Name="Nome do jogo")]
      public string Nome { get; set; }
      public string Descricao { get; set; }
      public string Imagem { get; set; }
      public bool Ativo { get; set; }

    }
}