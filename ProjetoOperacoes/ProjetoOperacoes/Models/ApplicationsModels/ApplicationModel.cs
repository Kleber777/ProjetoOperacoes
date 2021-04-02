using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public abstract class ApplicationModel
    {
        public ApplicationModel()
        {

        }

        public ApplicationModel(string idAccountType,
                                string description,
                                bool hasInstallments,
                                int paidInstallments,
                                int installments,
                                double individualValue,
                                ETypeApplication typeApplication)
        {
            ID = Guid.NewGuid().ToString();
            IdAccountType = idAccountType;
            Description = description;
            HasInstallments = hasInstallments;
            PaidInstallments = paidInstallments;
            Installments = installments;
            IndividualValue = individualValue;
            TypeApplication = typeApplication;
        }

        [Column("id")]
        public string ID { get; set; }

        [Column("idaccounttype")]
        public string IdAccountType { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("hasinstallments")]
        public bool HasInstallments { get; set; }

        [Column("paidinstallments")]
        public int PaidInstallments { get; set; }

        [Column("installments")]
        public int Installments { get; set; }

        [Column("individualvalue")]
        public double IndividualValue { get; set; }

        [Column("typeapplication")]
        public ETypeApplication TypeApplication { get; set; }

        // Esse atributo não é salvo no banco.
        [NotMapped]
        public double TotalValue { get; private set; }

    }
}
