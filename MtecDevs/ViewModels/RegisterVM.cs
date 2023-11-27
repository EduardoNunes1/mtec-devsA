using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome", Prompt = "Informe seu Nome")]
    [Required(ErrorMessage = "Por favor, informe um nome válido")]
    public string Nome { get; set; }

    [Display(Name = "Email", Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu email")]
    public string Email { get; set; }

    [Display(Name = "Data de Nascimento", Prompt = "Infome sua data de nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    public DateTime DataNascimento { get; set; }
    
    [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }
    
    [Display(Name = "Área em que atua", Prompt = "Informe sua Área de Desenvolvimento")]
    [Required(ErrorMessage = "Por favor, informe a área em que atua")]
    public byte TipoDevId { get; set; }

    [Display(Name = "Foto de Perfil", Prompt = "Adicione uma foto de perfil")]
    public string Foto { get; set; }
}