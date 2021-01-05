namespace ProjetoOperacoes.Models
{
    public class ProgressApplicationModel : ApplicationModels
    {
        public int RemainingInstallments { get; set; }
        public int PayInstallments { get; set; }
        public int NumberInstallments { get; set; }

        public ProgressApplicationModel(string id, string idTiposContas, string descricao, bool parcelas, decimal valorIndividual, decimal valorTotal) : base(id, idTiposContas, descricao, parcelas, valorIndividual, valorTotal)
        {

        }
    }
}
