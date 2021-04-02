namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class ConsolidatedApplicationModel : ApplicationModel
    {
        public ConsolidatedApplicationModel()
        {

        }
        public ConsolidatedApplicationModel(string idAccountType,
                                            string description,
                                            bool hasInstallments,
                                            int paidInstallments,
                                            int installments,
                                            double individualValue,
                                            ETypeApplication typeApplication) : base(idAccountType, description, hasInstallments, paidInstallments, installments, individualValue, typeApplication)
        {

        }
    }
}
