using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.Services.AccountTypeServices;
using ProjetoOperacoes.ViewModel;
using System.Globalization;

namespace ProjetoOperacoes.Comandos.AccountTypeCommands
{
    public class ReadAccountTypeCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            App.PrincipalViewModel.BankSelected = (BankInputModel)parameter;

            var itens = ServicesAccountType.AccountsTypeListByIdAccount(App.PrincipalViewModel.BankSelected.ID);
            App.PrincipalViewModel.DadosConta = App.PrincipalViewModel.BankSelected.BankName + "   " + App.PrincipalViewModel.BankSelected.Amount.ToString("N2", CultureInfo.CurrentCulture);

            App.PrincipalViewModel.LimparObservableCollection();
            App.PrincipalViewModel.LimparValoresViewModel();
            App.PrincipalViewModel.ListaTiposContas.Clear();

            foreach (var item in itens)
                App.PrincipalViewModel.ListaTiposContas.Add(new AccountTypeInputModel(item.ID, item.IdBank, item.NameAccountType, item.AccountType,/* null, null, null, null,*/ item.Balance));
        }
    }
}
