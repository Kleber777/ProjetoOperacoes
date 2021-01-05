namespace ProjetoOperacoes.Models
{
    public class AccountTypeModel
    {

        public AccountTypeModel()
        {

        }
        public int Id { get; set; }
        public int IdContas { get; set; }
        public string NomeTipoConta { get; set; }
        //1 = Conta Corrente, 2 = Conta Poupança
        public int TipoConta { get; set; }
        public decimal ValorTotalConta { get; set; }
    }
}
