using ProjetoOperacoes.Models.ApplicationsModels.Builders;
using ProjetoOperacoes.Models.ApplicationsModels.Components;
using System;

namespace ProjetoOperacoes.Models.ApplicationsModels.Directors
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateConsolidatedApplication(string idAccountType, string description, double individualValue)
        {
            builder.SetIdAccountType(idAccountType);
            builder.SetRepeatedId(Guid.NewGuid().ToString());
            builder.SetDescription(description);
            builder.SetHasInstallments(false);
            builder.SetPaidInstallments(0);
            builder.SetInstallments(1);
            builder.SetIndividualValue(individualValue);
            builder.SetTypeApplication(ETypeApplication.CONSOLIDATED);
            
        }
        public void CreateFutureApplication(string idAccountType, string description, double individualValue)
        {
            builder.SetIdAccountType(idAccountType);
            builder.SetRepeatedId(Guid.NewGuid().ToString());
            builder.SetDescription(description);
            builder.SetHasInstallments(false);
            builder.SetPaidInstallments(0);
            builder.SetInstallments(1);
            builder.SetIndividualValue(individualValue);
            builder.SetTypeApplication(ETypeApplication.FUTURE);
            
        }
        public void CreateApplicationWithInstallments(string idAccountType, string description, int installments, double individualValue)
        {
            builder.SetIdAccountType(idAccountType);
            builder.SetDescription(description);
            builder.SetHasInstallments(false);
            builder.SetPaidInstallments(0);
            builder.SetInstallments(installments);
            builder.SetIndividualValue(individualValue);
            builder.SetTypeApplication(ETypeApplication.PROGRESS);
            builder.SetRepeatedId();
            builder.ResetRepeatedId();
        }

    }
}
