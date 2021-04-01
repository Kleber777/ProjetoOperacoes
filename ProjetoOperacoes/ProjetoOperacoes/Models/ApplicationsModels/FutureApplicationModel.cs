namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class FutureApplicationModel : ApplicationModel
    {
        public FutureApplicationModel()
        {

        }

        public FutureApplicationModel(string idApplicationType,
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
