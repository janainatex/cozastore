using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[ Table("Produto")]

public class Produto
{
[Key]
 [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; }      

[Required(ErrorMessage = "Por favor, informe o Nome")]
[StringLength(100, ErrorMessage = "Nome deve possuir no maximo 100 caracteres")]
  public string Nome {get; set; }

  [Display(Name ="Descrição Resumida")]
  [StringLength(1000, ErrorMessage = "A Descrição Resumida deve possuir no máximo 1000 caracteres")]
  public string DescricaoResumida { get; set; }

[Display(Name ="Descrição Completa")]
[StringLength(8000, ErrorMessage = "A Descrição Resumida deve possuir no máximo 8000 caracteres")]
  public string DescricaoCompleta { get; set; }

  [Display(Name = "SKU")]
  [StringLength(10, ErrorMessage = " SKU deve possuir no máximo 10 caracteres")]
  public string SKU { get; set; }

  [Display(Name ="Preço de Venda")]
  [Column(TypeName = "decimal(12,2)")]
  [Required(ErrorMessage = "Por favor, informe o Preço de Venda ")]
  public decimal Preco { get; set; }

  [Display(Name ="Preço com Desconnto")]
  [Column(TypeName = "decimal(2,2)")]
  [Required(ErrorMessage = "Por favor, informe o Preço com Desconto")]
  public decimal PrecoDesconto { get; set; }

  [Display(Name ="Produto  em Destaque?-")]
  public bool Destaque { get; set; }

  [Column(TypeName = "decimal(8,3)")]
  public double Peso { get; set; }

[StringLength(50, ErrorMessage = "O Material deve possuir no máximo 30 caracteres")]
public string Material { get; set; } 
[Display(Name = "Dimensões")]
[StringLength(20, ErrorMessage = "A s Dimensões devem possuir no máximo 20 caracteres")]
public string Dimensao { get; set; }

[Display(Name ="Categoria")]
[Required(ErrorMessage = "Por favor , informe a categoria")]
[ForeignKey("CategoriaId")]

public Categoria Categoria { get; set; }

public ICollection<Estoque> Estoque { get; set; }

public ICollection<ProdutoFoto> Foto { get; set; }

}