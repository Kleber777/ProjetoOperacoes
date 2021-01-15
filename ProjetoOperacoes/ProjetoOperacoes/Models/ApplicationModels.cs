using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models
{
    public abstract class ApplicationModels
    {
        protected ApplicationModels()
        {

        }
        public ApplicationModels(string id, string idAccountTypes, string description, bool hasInstallments, double individualValue, double totalValue)
        {
            Id = id;
            IdAccountTypes = idAccountTypes;
            Description = description;
            HasInstallments = hasInstallments;
            IndividualValue = individualValue;
            TotalValue = totalValue;
        }

        [Column("id")]
        public string Id { get; set; }

        [Column("idaccounttypes")]
        public string IdAccountTypes { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("hasinstallments")]
        public bool HasInstallments { get; set; }

        [Column("individualvalue")]
        public double IndividualValue { get; set; }

        [Column("totalvalue")]
        public double TotalValue { get; set; }

    }
}
