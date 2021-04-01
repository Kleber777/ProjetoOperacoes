namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class AccomplishedApplicationModel : ApplicationModel
    {
        public AccomplishedApplicationModel()
        {

        }

        public AccomplishedApplicationModel(string id,
                                            string idApplicationType,
                                            string idAccountType,
                                            string description,
                                            bool hasInstallments,
                                            int paidInstallments,
                                            int installments,
                                            double individualValue,
                                            ETypeApplication typeApplication) : base(idApplicationType, idAccountType, description, hasInstallments, paidInstallments, installments, individualValue, typeApplication)
        {
            ID = id;
        }
    }
}
