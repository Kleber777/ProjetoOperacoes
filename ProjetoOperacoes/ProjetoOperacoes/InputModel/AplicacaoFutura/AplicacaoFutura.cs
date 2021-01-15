namespace ProjetoOperacoes.InputModel.AplicacaoFutura
{
    public class AplicacaoFutura
    {
        public AplicacaoFutura(string iD, string idTiposContas, string descricao, int parcelas, double valorIndividual, double valorTotal)
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
        public double ValorIndividual { get; set; }
        public double ValorTotal { get; set; }

    }
}
