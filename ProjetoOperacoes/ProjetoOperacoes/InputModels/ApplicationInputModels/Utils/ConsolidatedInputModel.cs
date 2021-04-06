using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.InputModels.ApplicationInputModels.Utils
{
    public class ConsolidatedInputModel : ApplicationInputModel
    {
        public ConsolidatedInputModel()
        {

        }

        public ConsolidatedInputModel(string id, string idAccountType, string repeatedId, string description, bool hasInstallments, int paidInstallments, int installments, double individualValue, double totalValue, ETypeApplication eTypeApplication) : base(id, idAccountType, repeatedId, description, hasInstallments, paidInstallments, installments, individualValue, totalValue, eTypeApplication)
        {

        }
    }
}
