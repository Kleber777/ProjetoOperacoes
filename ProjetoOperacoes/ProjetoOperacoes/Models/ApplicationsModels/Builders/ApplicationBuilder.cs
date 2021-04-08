using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.Models.ApplicationsModels.Builders
{
    public class ApplicationBuilder : IBuilder
    {
        public ApplicationBuilder()
        {
            ResetRepeatedId();
        }

        private ApplicationModel ApplicationModel = new ApplicationModel();
        private string RepeatedId;

        public ApplicationModel GetApplication()
        {
            var result = ApplicationModel;
            Reset();
            return result;
        }

        public void SetIdAccountType(string idAccountType)
        {
            ApplicationModel.IdAccountType = idAccountType;
        }
        public void SetRepeatedId(string repeatedId)
        {
            ApplicationModel.RepeatedId = repeatedId;
            RepeatedId = repeatedId;
        }
        public void SetRepeatedId()
        {
            ApplicationModel.RepeatedId = RepeatedId;
        }

        public void SetDescription(string description)
        {
            ApplicationModel.Description = description;
        }

        public void SetHasInstallments(bool hasInstallments)
        {
            ApplicationModel.HasInstallments = hasInstallments;
        }

        public void SetPaidInstallments(int paidInstallments)
        {
            ApplicationModel.PaidInstallments = paidInstallments;
        }

        public void SetInstallments(int installments)
        {
            ApplicationModel.Installments = installments;
        }

        public void SetIndividualValue(double individualValue)
        {
            ApplicationModel.IndividualValue = individualValue;
        }

        public void SetTypeApplication(ETypeApplication eTypeApplication)
        {
            ApplicationModel.TypeApplication = eTypeApplication;
        }

        public void Reset()
        {
            ApplicationModel = new ApplicationModel();
        }

        public void ResetRepeatedId()
        {
            RepeatedId = "";
        }
    }
}
