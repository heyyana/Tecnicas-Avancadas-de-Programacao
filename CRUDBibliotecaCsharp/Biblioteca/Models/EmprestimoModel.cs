using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class EmprestimoModel
    {

        // Modelo do Banco de Dados
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o campo do Recebedor")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage ="Digite o campo do Fornecedor")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage ="Digite o nome do Livro")]
        public string LivroEmprestado { get; set;}
        public DateTime Data { get; set; } = DateTime.Now; 
        // DateTime.Now = Pega a data (atual) da máquina.

    }
}
