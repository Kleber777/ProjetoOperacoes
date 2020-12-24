namespace ProjetoOperacoes.InputModel.AplicacaoFutura
{
    public class AplicacaoFutura
    {
        public AplicacaoFutura(string iD, string idTiposContas, string descricao, int parcelas, decimal valorIndividual, decimal valorTotal)
        {
            ID = iD;
            IdTiposContas = idTiposContas;
            Descricao = descricao;
            Parcelas = parcelas;
            ValorIndividual = valorIndividual;
            ValorTotal = valorTotal;
        }

        public string ID { get; set; }
        public string IdTiposContas { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public decimal ValorIndividual { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
