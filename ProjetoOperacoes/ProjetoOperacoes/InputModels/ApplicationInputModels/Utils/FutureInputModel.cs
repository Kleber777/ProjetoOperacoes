using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.InputModels.ApplicationInputModels.Utils
{
    public class FutureInputModel : ApplicationInputModel
    {
        public FutureInputModel(string id, string idAccountType, string repeatedId, string description, bool hasInstallments, int paidInstallments, int installments, double individualValue, double totalValue, ETypeApplication typeApplication) : base(id, idAccountType, repeatedId, description, hasInstallments, paidInstallments, installments, individualValue, totalValue, typeApplication)
        {

        }
    }
}
