namespace ProjetoOperacoes.Models.ApplicationsModels
{
    public class FutureApplicationModel : ApplicationModel
    {
        public FutureApplicationModel()
        {

        }

        public FutureApplicationModel(string idAccountType,
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
