using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MtecDevs.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public IdentityUser AccountUser { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Informe a Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [Display(Name = "Tipo de Desenvolvedor")]
    [Required(ErrorMessage = "Informe o Tipo de Desenvolvedor")]
    public byte TipoDevId { get; set; }
    [ForeignKey("TipoDevId")]
    public TipoDev TipoDev { get; set; }

}
