namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class ProgressApplicationModel : ApplicationModel
    {
        public ProgressApplicationModel()
        {

        }

        public ProgressApplicationModel(string idAccountType,
                                        string description,
                                        bool hasInstallments,
                                        int paidInstallments,
                                        int installments,
                                        double individualValue,
                                        ETypeApplication typeApplication) : base(idAccountType, description, hasInstallments, paidInstallments, installments, individualValue, typeApplication)
        {
            RemainingInstallments = Installments - PaidInstallments;
        }

        public int RemainingInstallments { get; set; }

    }
}
