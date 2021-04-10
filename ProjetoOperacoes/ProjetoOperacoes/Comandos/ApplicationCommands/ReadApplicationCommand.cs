using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.ViewModel;

namespace ProjetoOperacoes.Comandos.ApplicationCommands
{
    public class ReadApplicationCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            var tipoContaSelecionado = (AccountTypeInputModel)parameter;
            App.PrincipalViewModel.AccountTypeSelected = tipoContaSelecionado;
            App.PrincipalViewModel.NameAccountType = tipoContaSelecionado.NameAccountType;
            App.PrincipalViewModel.Balance = tipoContaSelecionado.Balance.ToString();
            App.PrincipalViewModel.LimparObservableCollection();
            App.PrincipalViewModel.CarregarListasAplicacoes();
        }
    }
}
