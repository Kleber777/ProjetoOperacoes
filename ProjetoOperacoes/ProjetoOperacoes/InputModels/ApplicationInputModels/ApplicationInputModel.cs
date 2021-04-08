using ProjetoOperacoes.Models.ApplicationsModels.Components;

namespace ProjetoOperacoes.InputModels.ApplicationInputModels
{
    public class ApplicationInputModel
    {
        public ApplicationInputModel()
        {
                
        }
        public ApplicationInputModel(string id, string idAccountType, string repeatedId, string description, bool hasInstallments, int paidInstallments, int installments, double individualValue, double totalValue, ETypeApplication typeApplication)
        {
            Id = id;
            IdAccountType = idAccountType;
            RepeatedId = repeatedId;
            Description = description;
            HasInstallments = hasInstallments;
            PaidInstallments = paidInstallments;
            Installments = installments;
            IndividualValue = individualValue;
            TotalValue = totalValue;
            TypeApplication = typeApplication;
        }

        public string Id { get; set; }
        public string IdAccountType { get; set; }
        public string RepeatedId { get; set; }
        public string Description { get; set; }
        public bool HasInstallments { get; set; }
        public int PaidInstallments { get; set; }
        public int Installments { get; set; }
        public double IndividualValue { get; set; }
        public double TotalValue { get; private set; }
        public ETypeApplication TypeApplication { get; set; }

    }
}
