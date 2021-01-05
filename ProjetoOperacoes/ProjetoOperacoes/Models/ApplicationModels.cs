namespace ProjetoOperacoes.Models
{
    public class ApplicationModels
    {
        public ApplicationModels(string id, string idAccountTypes, string description, bool hasInstallments, decimal individualValue, decimal totalValue)
        {
            Id = id;
            IdAccountTypes = idAccountTypes;
            Description = description;
            HasInstallments = hasInstallments;
            IndividualValue = individualValue;
            TotalValue = totalValue;
        }

        public string Id { get; set; }
        public string IdAccountTypes { get; set; }
        public string Description { get; set; }
        public bool HasInstallments { get; set; }
        public decimal IndividualValue { get; set; }
        public decimal TotalValue { get; set; }

    }
}
