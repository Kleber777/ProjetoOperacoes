using ProjetoOperacoes.Services.AccountTypeServices;
using ProjetoOperacoes.ViewModel;

namespace ProjetoOperacoes.Comandos.AccountTypeCommands
{
    public class UpdateAccountTypeCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            ServicesAccountType.UpdateBalanceAccountType(App.PrincipalViewModel.AccountTypeSelected, App.PrincipalViewModel.NewBalanceAccountType);
            App.PrincipalViewModel.IsOpenUpdateAccountType = false;
            ServicesAccountType.ReadAccountTypeList(App.PrincipalViewModel.BankSelected.ID);
        }
    }
}
