using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    [Table("tb_consolidateapplication")]
    public class ConsolidatedApplicationModel : ApplicationModels
    {
        public ConsolidatedApplicationModel() 
        {

        }

        public ConsolidatedApplicationModel(string id, string idTiposContas, string descricao, bool parcelas, double valorIndividual, double valorTotal) : base(id, idTiposContas, descricao, parcelas, valorIndividual, valorTotal)
        {

        }

        [Column("consolidationperiod")]
        public int ConsolidationPeriod { get; set; }

        //Isso aqui era para ser string não lembro o porque
        [Column("consolidationtypeperiod")]
        public int ConsolidationTypePeriod { get; set; }

        [Column("installments")]
        public int Installments { get; set; }
    }
}
