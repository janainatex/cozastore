using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Cozastore.Models;

[Table("Usuario")]

public class Usuario
{
    [Key]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")] 
    public IdentityUser ContaUsuario { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "Nome deve possuir no maximo 60 caracteres")]
    public string Nome {get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor ,informe a data de Nacsimento")]
    public DateTime DatadeNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

   
   
    

}