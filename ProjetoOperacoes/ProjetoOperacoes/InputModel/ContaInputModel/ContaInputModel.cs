namespace ProjetoOperacoes.InputModel.ContaInputModel
{
    public class ContaInputModel
    {
        public ContaInputModel()
        {

        }
        public ContaInputModel(string iD, string nomeBanco, string corHexadouble, string icone, double valorTotal)
        {
            ID = iD;
            NomeBanco = nomeBanco;
            CorHexadouble = corHexadouble;
            Icone = icone;
            ValorTotal = valorTotal;
        }

        public string ID { get; set; }
        public string NomeBanco { get; set; }
        public string CorHexadouble { get; set; }
        public string Icone { get; set; }
        public double ValorTotal { get; set; }
    }
}
