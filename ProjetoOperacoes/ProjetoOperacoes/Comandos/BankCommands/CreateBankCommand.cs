using ProjetoOperacoes.Services.BankServices;
using ProjetoOperacoes.ViewModel;
using System;

namespace ProjetoOperacoes.Comandos.BankCommands
{
    public class CreateBankCommand : BaseCommand
    {
        public override void Execute(object parameter)
        {
            ServicesBank.InsertBank(new InputModels.BankInputModel());
            App.PrincipalViewModel.ListaContas.Clear();
            App.PrincipalViewModel.CarregarDados();
        }
    }
}
