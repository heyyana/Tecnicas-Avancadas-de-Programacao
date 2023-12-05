namespace LocacaoCarro.Models
{
    public class JuridicoModel : ClienteModel
    {
        public int Id { get; set; }
        public string nome_fantasia { get; set; }
        public string cnpj { get; set; }
    }
}
