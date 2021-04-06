using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.Models.ApplicationsModels.Builders
{
    public class ApplicationBuilder : IBuilder
    {
        private ApplicationModel ApplicationModel;
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
            throw new System.NotImplementedException();
        }

        public void SetHasInstallments(bool hasInstallments)
        {
            throw new System.NotImplementedException();
        }

        public void SetPaidInstallments(int paidInstallments)
        {
            throw new System.NotImplementedException();
        }

        public void SetInstallments(int installments)
        {
            throw new System.NotImplementedException();
        }

        public void SetIndividualValue(double individualValue)
        {
            throw new System.NotImplementedException();
        }

        public void SetTypeApplication(ETypeApplication eTypeApplication)
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            ApplicationModel = new ApplicationModel();
            RepeatedId = "";
        }
    }
}
