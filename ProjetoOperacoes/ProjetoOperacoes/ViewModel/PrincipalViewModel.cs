using ProjetoOperacoes.Comandos.AccountTypeCommands;
using ProjetoOperacoes.Comandos.ApplicationCommands;
using ProjetoOperacoes.Comandos.BankCommands;
using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels.Utils;
using ProjetoOperacoes.Models.ApplicationsModels.Components;
using ProjetoOperacoes.Services.ApplicationServices;
using ProjetoOperacoes.Services.BankServices;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ProjetoOperacoes.ViewModel
{
    public class PrincipalViewModel : BaseViewModel, IPageViewModel
    {
        private ICommand _goTo2;
        public ICommand GoTo2
        {
            get
            {
                return _goTo2 ?? (_goTo2 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToTestePage", "");
                }));
            }
        }

        #region 1 - Properties PrincipalViewModel
        private BankInputModel _bankSelected;
        public BankInputModel BankSelected
        {
            get
            {
                return _bankSelected;
            }
            set
            {
                _bankSelected = value;
                OnPropertyChanged("BankSelected");
            }

        }

        private AccountTypeInputModel _accountTypeSelected;
        public AccountTypeInputModel AccountTypeSelected
        {
            get
            {
                return _accountTypeSelected;
            }
            set
            {
                _accountTypeSelected = value;
                OnPropertyChanged("AccountTypeSelected");
            }

        }

        private ApplicationInputModel _applicationSelected;
        public ApplicationInputModel ApplicationSelected
        {
            get
            {
                return _applicationSelected;
            }
            set
            {
                _applicationSelected = value;
                OnPropertyChanged("ApplicationSelected");
            }

        }
        public ObservableCollection<BankInputModel> ListaContas { get; set; }
        public ObservableCollection<AccountTypeInputModel> ListaTiposContas { get; set; }
        public ObservableCollection<ConsolidatedInputModel> ListaConsolidada { get; set; }
        public ObservableCollection<FutureInputModel> ListaFutura { get; set; }
        public ObservableCollection<ProgressApplication> ListaEmAndamento { get; set; }
        public ObservableCollection<AccomplishedInputModel> ListaRealizada { get; set; }

        private double _newBalanceAccountType;
        public double NewBalanceAccountType
        {
            get
            {
                return _newBalanceAccountType;
            }
            set
            {
                _newBalanceAccountType = value;
                OnPropertyChanged("NewBalanceAccountType");
            }

        }
        private bool _isOpenUpdateAccountType;
        public bool IsOpenUpdateAccountType
        {
            get
            {
                return _isOpenUpdateAccountType;
            }
            set
            {
                _isOpenUpdateAccountType = value;
                OnPropertyChanged("IsOpenUpdateAccountType");
            }

        }


        private string _dadosConta;
        public string DadosConta
        {
            get
            {
                return _dadosConta;
            }
            set
            {
                _dadosConta = value;
                OnPropertyChanged("DadosConta");
            }

        }

        private string _nameAccountType;
        public string NameAccountType
        {
            get
            {
                return _nameAccountType;
            }
            set
            {
                _nameAccountType = value;
                OnPropertyChanged("NameAccountType");
            }

        }

        private string _balance;
        public string Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
                OnPropertyChanged("Balance");
            }

        }

        // Total que eu tenho hoje sem as contas em progresso e sem as contas futuras
        private double _totalAtual;
        public double TotalAtual
        {
            get
            {
                return _totalAtual;
            }
            set
            {
                _totalAtual = value;
                OnPropertyChanged("TotalAtual");
            }

        }

        // Totais das listas Consolidadas e Futuras
        private double _totalConsolidatedApplication;
        public double TotalConsolidatedApplication
        {
            get
            {
                return _totalConsolidatedApplication;
            }
            set
            {
                _totalConsolidatedApplication = value;
                OnPropertyChanged("TotalConsolidatedApplication");
            }

        }

        private double _totalComFutureApplication;
        public double TotalComFutureApplication
        {
            get
            {
                return _totalComFutureApplication;
            }
            set
            {
                _totalComFutureApplication = value;
                OnPropertyChanged("TotalComFutureApplication");
            }

        }

        // Final que eu tenho hoje sem o total das contas em progresso e das contas futuras
        private double _finalTotalAtual;
        public double FinalTotalAtual
        {
            get
            {
                return _finalTotalAtual;
            }
            set
            {
                _finalTotalAtual = value;
                OnPropertyChanged("FinalTotalAtual");
            }

        }

        // Finais das listas Consolidadas e Futuras
        private double _finalBalanceConsolidatedApplication;
        public double FinalBalanceConsolidatedApplication
        {
            get
            {
                return _finalBalanceConsolidatedApplication;
            }
            set
            {
                _finalBalanceConsolidatedApplication = value;
                OnPropertyChanged("FinalBalanceConsolidatedApplication");
            }

        }

        private double _finalTotalComFutureApplication;
        public double FinalTotalComFutureApplication
        {
            get
            {
                return _finalTotalComFutureApplication;
            }
            set
            {
                _finalTotalComFutureApplication = value;
                OnPropertyChanged("FinalTotalComFutureApplication");
            }

        }

        //Totais individuas de cada lista
        private double _totalAllApplications;
        public double TotalAllApplications
        {
            get
            {
                return _totalAllApplications;
            }
            set
            {
                _totalAllApplications = value;
                OnPropertyChanged("TotalAllApplications");
            }

        }
        #endregion

        #region 2 - Commands Properties
        //PrincipalViewModel - Commands Properties
        public CaptureApplicationCommand CaptureApplication { get; set; }
        public GoToNewApplicationCommand GoToNewApplication { get; set; }
        public UpdateBalanceAccountTypeCommand UpdateBalanceAccountType { get; set; }
        public CancelUpdateBalanceAccountTypeCommand CancelUpdateBalanceAccountType { get; set; }

        //BankCommands Properties
        public CreateBankCommand CreateBank { get; set; }
        public ReadBankCommand ReadBank { get; set; }
        public UpdateBankCommand UpdateBank { get; set; }
        public DeleteBankCommand DeleteBank { get; set; }

        //AccountTypeCommands Properties
        public CreateAccountTypeCommand CreateAccountType { get; set; }
        public ReadAccountTypeCommand ReadAccountType { get; set; }
        public UpdateAccountTypeCommand UpdateAccountType { get; set; }
        public DeleteAccountTypeCommand DeleteAccountType { get; set; }

        //ApplicationCommands Properties
        public CreateApplicationCommand CreateApplication { get; set; }
        public ReadApplicationCommand ReadApplication { get; set; }
        public UpdateApplicationCommand UpdateApplication { get; set; }
        public DeleteApplicationCommand DeleteApplication { get; set; }
        #endregion

        #region 3 - Builders
        public PrincipalViewModel()
        {

            //Instanciando Objetos PrincipalView Model
            BankSelected = new BankInputModel();
            AccountTypeSelected = new AccountTypeInputModel();
            ApplicationSelected = new ApplicationInputModel();
            ListaContas = new ObservableCollection<BankInputModel>();
            ListaTiposContas = new ObservableCollection<AccountTypeInputModel>();
            ListaConsolidada = new ObservableCollection<ConsolidatedInputModel>();
            ListaFutura = new ObservableCollection<FutureInputModel>();
            ListaEmAndamento = new ObservableCollection<ProgressApplication>();
            ListaRealizada = new ObservableCollection<AccomplishedInputModel>();

            //Instanciando Commands
            CaptureApplication = new CaptureApplicationCommand();
            GoToNewApplication = new GoToNewApplicationCommand();
            UpdateBalanceAccountType = new UpdateBalanceAccountTypeCommand();
            CancelUpdateBalanceAccountType = new CancelUpdateBalanceAccountTypeCommand();

            CreateBank = new CreateBankCommand();
            ReadBank = new ReadBankCommand();
            UpdateBank = new UpdateBankCommand();
            DeleteBank = new DeleteBankCommand();
            CreateAccountType = new CreateAccountTypeCommand();
            ReadAccountType = new ReadAccountTypeCommand();
            UpdateAccountType = new UpdateAccountTypeCommand();
            DeleteAccountType = new DeleteAccountTypeCommand();
            CreateApplication = new CreateApplicationCommand();
            ReadApplication = new ReadApplicationCommand();
            UpdateApplication = new UpdateApplicationCommand();
            DeleteApplication = new DeleteApplicationCommand();

            //Chamando métodos
            CarregarDados();
        }
        #endregion

        #region 4 - Métodos
        protected internal void CarregarDados()
        {
            var lstContas = ServicesBank.BankList();

            foreach (var item in lstContas)
                ListaContas.Add(new BankInputModel(item.ID, item.BankName, item.HexColor, item.Icon, item.Amount));
        }
        protected internal void LimparObservableCollection()
        {
            ListaTiposContas.Clear();
            App.PrincipalViewModel.ListaConsolidada.Clear();
            App.PrincipalViewModel.ListaFutura.Clear();
            App.PrincipalViewModel.ListaEmAndamento.Clear();
            App.PrincipalViewModel.ListaRealizada.Clear();
        }
        protected internal void LimparValoresViewModel()
        {
            App.PrincipalViewModel.TotalAtual = 0;
            App.PrincipalViewModel.TotalConsolidatedApplication = 0;
            App.PrincipalViewModel.TotalComFutureApplication = 0;
            App.PrincipalViewModel.FinalTotalAtual = 0;
            App.PrincipalViewModel.FinalBalanceConsolidatedApplication = 0;
            App.PrincipalViewModel.FinalTotalComFutureApplication = 0;
        }
        protected internal void CarregarListasAplicacoes ()
        {
            ListaConsolidada.Clear();
            ListaFutura.Clear();
            ListaEmAndamento.Clear();
            ListaRealizada.Clear();
            TotalConsolidatedApplication = 0;

            var lstApplication = ServicesApplication.ReadApplicationListByIdAccountType(AccountTypeSelected.ID);

            // ConsolidatedList
            List<ApplicationInputModel> itensConsolidados = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.CONSOLIDATED);
            foreach (var item in itensConsolidados)
            {
                ListaConsolidada.Add(new ConsolidatedInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                            item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

                 TotalConsolidatedApplication += item.HasInstallments ? 
                    item.IndividualValue * (item.Installments - item.PaidInstallments) : item.IndividualValue * item.Installments;
            }

            FinalBalanceConsolidatedApplication = AccountTypeSelected.Balance - TotalConsolidatedApplication;

            // FutureList
            List<ApplicationInputModel> itensFuturos = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.FUTURE);
            foreach (var item in itensFuturos)
                ListaFutura.Add(new FutureInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                       item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            // ProgressList
            List<ApplicationInputModel> itensEmAndamento = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.PROGRESS);
            foreach (var item in itensEmAndamento)
                ListaEmAndamento.Add(new ProgressApplication(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                            item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

            // AccomplishedList
            List<ApplicationInputModel> itensRealizados = lstApplication.FindAll(c => c.TypeApplication == ETypeApplication.ACCOMPLISHED);
            foreach (var item in itensRealizados)
                ListaRealizada.Add(new AccomplishedInputModel(item.Id, item.IdAccountType, item.RepeatedId, item.Description,
                                                          item.HasInstallments, item.PaidInstallments, item.Installments, item.IndividualValue, item.TotalValue, item.TypeApplication));

        }
        #endregion

        #region 5 - Classes de Comandos PrincipalViewModel
        public class CaptureApplicationCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                ApplicationInputModel application = (ApplicationInputModel)parameter;
                App.PrincipalViewModel.ApplicationSelected = application;
            }
        }
        public class GoToNewApplicationCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                App.ApplicationPagesViewModel.CurrentPageViewModel = App.ApplicationPagesViewModel.PageViewModels[Paginas.TestePageView];
            }
        }
        public class UpdateBalanceAccountTypeCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                App.PrincipalViewModel.IsOpenUpdateAccountType = true;
            }
        }
        public class CancelUpdateBalanceAccountTypeCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                App.PrincipalViewModel.IsOpenUpdateAccountType = false;
                App.PrincipalViewModel.NewBalanceAccountType = 0;
            }
        }
        #endregion
    }
}
