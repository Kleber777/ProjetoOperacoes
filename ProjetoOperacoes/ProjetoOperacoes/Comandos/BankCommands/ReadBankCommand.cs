using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.Services.BankServices;
using ProjetoOperacoes.ViewModel;

namespace ProjetoOperacoes.Comandos.BankCommands
{
    public class ReadBankCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            var lstContas = ServicesBank.BankList();

            foreach (var item in lstContas)
                App.PrincipalViewModel.ListaContas.Add(new BankInputModel(item.ID, item.BankName, item.HexColor, item.Icon, item.Amount));
        }
    }
}
