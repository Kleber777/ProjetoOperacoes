using ProjetoOperacoes.InputModels.ApplicationInputModels;
using ProjetoOperacoes.Services.ApplicationServices;
using ProjetoOperacoes.ViewModel;

namespace ProjetoOperacoes.Comandos.ApplicationCommands
{
    public class UpdateApplicationCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            ApplicationInputModel application = App.PrincipalViewModel.ApplicationSelected;
            ServicesApplication.UpdateApplication(application);

        }
    }
}
