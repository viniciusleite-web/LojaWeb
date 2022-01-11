using System.ComponentModel.DataAnnotations;

namespace LojaWeb.Models
{
    public class ClienteViewModel
    {
        [Required]
        [Display(Name = "Nome e Sobrenome")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Endereço do cliente")]
        public string Endereço { get; set; }
        [Required]
        
        public string CPF { get; set; }

        
        
    }
}
