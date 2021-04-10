using ProjetoOperacoes.Models.ApplicationsModels.Builders;
using ProjetoOperacoes.Models.ApplicationsModels.Directors;
using ProjetoOperacoes.Services.ApplicationServices;
using ProjetoOperacoes.ViewModel;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System;

namespace ProjetoOperacoes.Comandos.ApplicationCommands
{
    public class CreateApplicationCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            ApplicationBuilder builder = new ApplicationBuilder();
            Director director = new Director(builder);

            if (App.TestePageViewModel.IsConsolidated)
            {
                director.CreateConsolidatedApplication(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                       App.TestePageViewModel.Description,
                                                       Convert.ToDouble(App.TestePageViewModel.IndividualValue));
            }
            else
            {
                director.CreateFutureApplication(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                 App.TestePageViewModel.Description,
                                                 Convert.ToDouble(App.TestePageViewModel.IndividualValue));

            }

            // Aqui ele reseta a aplicação e não o RepeteadId
            var model = builder.GetApplication();

            // Passar a model para o banco Db.SaveChanges(model);
            ServicesApplication.CreateApplication(model);

            if (App.TestePageViewModel.HadInstallments)
            {
                director.CreateApplicationWithInstallments(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                           App.TestePageViewModel.Description,
                                                           Convert.ToInt32(App.TestePageViewModel.CountInstallments),
                                                           Convert.ToDouble(App.TestePageViewModel.IndividualValue));

                var modelWithInstallments = builder.GetApplication();

                // Passar a model para o banco Db.SaveChanges(modelWithInstallments);
                ServicesApplication.CreateApplication(modelWithInstallments);

            }

            App.ApplicationPagesViewModel.CurrentPageViewModel = App.ApplicationPagesViewModel.PageViewModels[Paginas.PrincipalView];
            App.PrincipalViewModel.CarregarListasAplicacoes();

        }
    }
}
