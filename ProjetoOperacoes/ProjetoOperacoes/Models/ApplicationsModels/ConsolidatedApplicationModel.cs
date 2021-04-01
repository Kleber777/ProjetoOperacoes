namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class ConsolidatedApplicationModel : ApplicationModel
    {
        public ConsolidatedApplicationModel()
        {

        }
        public ConsolidatedApplicationModel(string idApplicationType,
                                            string idAccountType,
                                            string description,
                                            bool hasInstallments,
                                            int paidInstallments,
                                            int installments,
                                            double individualValue,
                                            ETypeApplication typeApplication) : base(idApplicationType, idAccountType, description, hasInstallments, paidInstallments, installments, individualValue, typeApplication)
        {

        }
    }
}
