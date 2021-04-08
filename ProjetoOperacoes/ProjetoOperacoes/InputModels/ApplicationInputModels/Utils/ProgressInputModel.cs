using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.InputModels.ApplicationInputModels.Utils
{
    public class ProgressApplication : ApplicationInputModel
    {
        public ProgressApplication(string id, string idAccountType, string repeatedId, string description, bool hasInstallments, int paidInstallments, int installments, double individualValue, double totalValue, ETypeApplication typeApplication) : base(id, idAccountType, repeatedId, description, hasInstallments, paidInstallments, installments, individualValue, totalValue, typeApplication)
        {

        }

        public int RemainingInstallments { get; set; }
    }
}
