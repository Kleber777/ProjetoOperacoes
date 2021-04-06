namespace ProjetoOperacoes.Models.ApplicationsModels.Utils
{
    public class ProgressApplication
    {
        public ProgressApplication()
        {

        }

        public ProgressApplication(ApplicationModel application)
        {
            RemainingInstallments = application.Installments - application.PaidInstallments;
        }

        public int RemainingInstallments { get; set; }

    }
}
