namespace ProjetoOperacoes.InputModels.ApplicationInputModels.Utils
{
    public class AccomplishedInputModel
    {
        public AccomplishedInputModel(string id, string idAccountType, string description, bool hasInstallments, int payInstallments, int installments, double individualValue, double totalValue)
        {
            Id = id;
            IdAccountType = idAccountType;
            Description = description;
            HasInstallments = hasInstallments;
            PayInstallments = payInstallments;
            Installments = installments;
            IndividualValue = individualValue;
            TotalValue = totalValue;
        }

        public string Id { get; set; }
        public string IdAccountType { get; set; }
        public string Description { get; set; }
        public bool HasInstallments { get; set; }
        public int PayInstallments { get; set; }
        public int Installments { get; set; }
        public double IndividualValue { get; set; }
        public double TotalValue { get; private set; }

    }
}
