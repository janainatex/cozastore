using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cozastore.Models;

[Table("cor")]

public class Cor
{
 [Key]
 [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }      

[Required(ErrorMessage = "Por favor, informe o Nome")]
[StringLength(30, ErrorMessage = "Nome deve possuir no maximo 30 caracteres")]
  public string Nome {get; set; }

[Display(Name = "", Prompt = "Código Hexa")]
[Required(ErrorMessage = "Por favor, informe o Código Hexa")]
[StringLength(7, ErrorMessage = "O Código Hexa deve possuir no maximo 7 caracteres")]
  public string CodigoHexa { get; set; }
    
}