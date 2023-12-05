using System.ComponentModel.DataAnnotations;

namespace Locadora.Models
{
    public class AluguelFilmeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo do Locador")]
        public string Locador { get; set; }

        [Required(ErrorMessage = "Digite o campo do Funcionario")]
        public string Funcionario { get; set; }

        [Required(ErrorMessage = "Digite o nome do Filme")]
        public string Filme { get; set; }

        [Required(ErrorMessage = "Digite o Genero")]
        public string Genero { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}

