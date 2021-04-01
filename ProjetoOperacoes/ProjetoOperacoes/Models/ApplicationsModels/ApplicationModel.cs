using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOperacoes.Models.ApplicationsModels
{
    [Table("tb_application")]
    public abstract class ApplicationModel : Identity
    {
        protected ApplicationModel()
        {
            //if (HasInstallments == false)
            //    TotalValue = IndividualValue;
            //else
            //    TotalValue = IndividualValue * Installments - (PayInstallments == 0 ? +0 : IndividualValue * PayInstallments);
        }

        protected ApplicationModel(string idApplicationType,
                                    string idAccountType,
                                    string description,
                                    bool hasInstallments,
                                    int paidInstallments,
                                    int installments,
                                    double individualValue,
                                    ETypeApplication typeApplication)
        {
            IdApplicationType = idApplicationType;
            IdAccountType = idAccountType;
            Description = description;
            HasInstallments = hasInstallments;
            PaidInstallments = paidInstallments;
            Installments = installments;
            IndividualValue = individualValue;
            TypeApplication = typeApplication;
        }


        [Column("idapplicationtype")]
        public string IdApplicationType { get; set; }

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
