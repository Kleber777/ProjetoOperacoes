using ProjetoOperacoes.Comandos;
using ProjetoOperacoes.InputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels;
using ProjetoOperacoes.InputModels.ApplicationInputModels.Utils;
using ProjetoOperacoes.Models.ApplicationsModels.Components;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;

namespace ProjetoOperacoes.ViewModel
{
    public class PrincipalViewModel : BaseViewModel, IPageViewModel
    {
        private static BankInputModel SelectedAccount = new BankInputModel { ID = "Teste",  BankName = "Teste Banco", HexColor = "#00FF07", Icon = "Não tem", Amount = 100000};
        private static Services ServicesPrincipalView;

        private static AccountTypeInputModel AccounTypeSelected;

        // Comando Para Mudar de Página
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

        #region Propriedades PrincipalViewModel
        public ObservableCollection<BankInputModel> ListaContas { get; set; }
        public ObservableCollection<AccountTypeInputModel> ListaTiposContas { get; set; }
        public ObservableCollection<ConsolidatedInputModel> ListaConsolidada { get; set; }
        public ObservableCollection<FutureInputModel> ListaFutura { get; set; }
        public ObservableCollection<ProgressApplication> ListaEmAndamento { get; set; }
        public ObservableCollection<AccomplishedInputModel> ListaRealizada { get; set; }

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
        private double _totalComFutureApplicationConsolidada;
        public double TotalComFutureApplicationConsolidada
        {
            get
            {
                return _totalComFutureApplicationConsolidada;
            }
            set
            {
                _totalComFutureApplicationConsolidada = value;
                OnPropertyChanged("TotalComFutureApplicationConsolidada");
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
        private double _finalTotalComFutureApplicationConsolidada;
        public double FinalTotalComFutureApplicationConsolidada
        {
            get
            {
                return _finalTotalComFutureApplicationConsolidada;
            }
            set
            {
                _finalTotalComFutureApplicationConsolidada = value;
                OnPropertyChanged("FinalTotalComFutureApplicationConsolidada");
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

        #region Propriedades de classes de comandos
        public IrParaTipoContaCommand IrParaTipoConta { get; set; }
        public InsertNewAccountCommand InsertNewAccount { get; set; }
        public IrParaAplicacoesCommand IrParaAplicacoes { get; set; }
        public EditarValorTipoContaCommand EditarValorTipoConta { get; set; }
        #endregion

        #region Construtores
        public PrincipalViewModel()
        {
            //Instanciando Serviço da PrincipalViewModel
            ServicesPrincipalView = new Services();

            //Instanciando Commands
            IrParaTipoConta = new IrParaTipoContaCommand();
            InsertNewAccount = new InsertNewAccountCommand();
            IrParaAplicacoes = new IrParaAplicacoesCommand();
            EditarValorTipoConta = new EditarValorTipoContaCommand();

            //Instanciando Listas
            ListaContas = new ObservableCollection<BankInputModel>();
            ListaTiposContas = new ObservableCollection<AccountTypeInputModel>();
            ListaConsolidada = new ObservableCollection<ConsolidatedInputModel>();
            ListaFutura = new ObservableCollection<FutureInputModel>();
            ListaEmAndamento = new ObservableCollection<ProgressApplication>();
            ListaRealizada = new ObservableCollection<AccomplishedInputModel>();

            AccounTypeSelected = new AccountTypeInputModel();

            //Chamando métodos
            CarregarDados();
        }
        #endregion

        #region Métodos
        private void CarregarDados()
        {
            var lstContas = ServicesPrincipalView.BankList();

            foreach (var item in lstContas)
                ListaContas.Add(new BankInputModel(item.ID, item.BankName, item.HexColor, item.Icon, item.Amount));
        }
        private void LimparObservableCollection()
        {
            App.PrincipalViewModel.ListaConsolidada.Clear();
            App.PrincipalViewModel.ListaFutura.Clear();
            App.PrincipalViewModel.ListaEmAndamento.Clear();
            App.PrincipalViewModel.ListaRealizada.Clear();
        }
        private void LimparValoresViewModel()
        {
            App.PrincipalViewModel.TotalAtual = 0;
            App.PrincipalViewModel.TotalComFutureApplicationConsolidada = 0;
            App.PrincipalViewModel.TotalComFutureApplication = 0;
            App.PrincipalViewModel.FinalTotalAtual = 0;
            App.PrincipalViewModel.FinalTotalComFutureApplicationConsolidada = 0;
            App.PrincipalViewModel.FinalTotalComFutureApplication = 0;
        }
        #endregion

        #region Classes de Comandos
        public class IrParaAplicacoesCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                var tipoContaSelecionado = (AccountTypeInputModel)parameter;

                App.PrincipalViewModel.NameAccountType = tipoContaSelecionado.NameAccountType;
                App.PrincipalViewModel.Balance = tipoContaSelecionado.Balance.ToString();

                App.PrincipalViewModel.LimparObservableCollection();

                var lstApplication = ServicesPrincipalView.ApplicationListByIdAccountType(tipoContaSelecionado.ID);

                // ConsolidatedList
                List<ApplicationInputModel> itensConsolidados = lstApplication.FindAll(c => c.ETypeApplication == ETypeApplication.CONSOLIDATED);
                foreach (var item in itensConsolidados)
                    App.PrincipalViewModel.ListaConsolidada.Add(new ConsolidatedInputModel());


            }
        }
        public class IrParaTipoContaCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                SelectedAccount = (BankInputModel)parameter;

                var itens = ServicesPrincipalView.AccountsTypeListByIdAccount(SelectedAccount.ID);
                App.PrincipalViewModel.DadosConta = SelectedAccount.BankName + "   " + SelectedAccount.Amount.ToString("N2", CultureInfo.CurrentCulture);

                App.PrincipalViewModel.LimparObservableCollection();
                App.PrincipalViewModel.LimparValoresViewModel();
                App.PrincipalViewModel.ListaTiposContas.Clear();

                foreach (var item in itens)
                    App.PrincipalViewModel.ListaTiposContas.Add(new AccountTypeInputModel(item.ID, item.IdBank, item.NameAccountType, item.AccountType,/* null, null, null, null,*/ item.Balance));
            }
        }
        public class InsertNewAccountCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                //var itemSelecionado = (BankInputModel)parameter;
                ServicesPrincipalView.InsertBank(SelectedAccount);
                App.PrincipalViewModel.ListaContas.Clear();
                App.PrincipalViewModel.CarregarDados();
            }
        }
        #endregion
    }
}
