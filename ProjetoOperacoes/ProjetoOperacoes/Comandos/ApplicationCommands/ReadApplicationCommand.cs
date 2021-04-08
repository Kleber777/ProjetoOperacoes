using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels.Utils;
using ProjetoOperacoes.Models.ApplicationsModels.Components;
using ProjetoOperacoes.Services.ApplicationServices;
using ProjetoOperacoes.ViewModel;
using System.Collections.Generic;

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

            var lstApplication = ServicesApplication.ReadApplicationListByIdAccountType(App.PrincipalViewModel.AccountTypeSelected.ID);

            // ConsolidatedList
            List<ApplicationInputModel> itensConsolidados = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.CONSOLIDATED);
            foreach (var item in itensConsolidados)
                App.PrincipalViewModel.ListaConsolidada.Add(new ConsolidatedInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                            item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            // FutureList
            List<ApplicationInputModel> itensFuturos = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.FUTURE);
            foreach (var item in itensFuturos)
                App.PrincipalViewModel.ListaFutura.Add(new FutureInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                       item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            // ProgressList
            List<ApplicationInputModel> itensEmAndamento = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.PROGRESS);
            foreach (var item in itensEmAndamento)
                App.PrincipalViewModel.ListaEmAndamento.Add(new ProgressApplication(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                            item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            // AccomplishedList
            List<ApplicationInputModel> itensRealizados = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.ACCOMPLISHED);
            foreach (var item in itensRealizados)
                App.PrincipalViewModel.ListaRealizada.Add(new AccomplishedInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                          item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));
        }
    }
}
