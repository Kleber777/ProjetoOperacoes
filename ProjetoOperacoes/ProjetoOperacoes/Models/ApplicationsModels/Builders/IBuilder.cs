using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.Models.ApplicationsModels.Builders
{
    public interface IBuilder
    {
        ApplicationModel GetApplication();
        void SetIdAccountType(string idAccountType);
        void SetRepeatedId(string repeatedId);
        void SetDescription(string description);
        void SetHasInstallments(bool hasInstallments);
        void SetPaidInstallments(int paidInstallments);
        void SetInstallments(int installments);
        void SetIndividualValue(double individualValue);
        void SetTypeApplication(ETypeApplication eTypeApplication);
       
        /// <summary>
        /// Chamado somente no director CreateApplicationWithInstallments
        /// </summary>
        void SetRepeatedId();

        /// <summary>
        /// Chamado somente no director CreateApplicationWithInstallments
        /// </summary>
        void Reset();

        void ResetRepeatedId();

    }
}
