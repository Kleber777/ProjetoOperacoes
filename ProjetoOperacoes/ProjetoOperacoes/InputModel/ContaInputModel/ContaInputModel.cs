namespace ProjetoOperacoes.InputModel.ContaInputModel
{
    public class ContaInputModel
    {
        public ContaInputModel(string iD, string nomeBanco, string corHexadecimal, string icone, decimal valorTotal)
        {
            ID = iD;
            NomeBanco = nomeBanco;
            CorHexadecimal = corHexadecimal;
            Icone = icone;
            ValorTotal = valorTotal;
        }

        public string ID { get; set; }
        public string NomeBanco { get; set; }
        public string CorHexadecimal { get; set; }
        public string Icone { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
