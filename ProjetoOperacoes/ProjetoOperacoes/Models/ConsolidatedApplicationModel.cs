namespace ProjetoOperacoes.Models
{
    public class ConsolidatedApplicationModel : ApplicationModels
    {
        public ConsolidatedApplicationModel(string id, string idTiposContas, string descricao, bool parcelas, decimal valorIndividual, decimal valorTotal) : base(id, idTiposContas, descricao, parcelas, valorIndividual, valorTotal)
        {

        }
    }
}
