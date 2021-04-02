namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class AccomplishedApplicationModel : ApplicationModel
    {
        public AccomplishedApplicationModel()
        {

        }

        public AccomplishedApplicationModel(string idAccountType,
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
