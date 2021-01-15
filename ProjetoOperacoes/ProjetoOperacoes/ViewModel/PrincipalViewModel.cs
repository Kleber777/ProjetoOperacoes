using ProjetoOperacoes.InputModel.AplicacaoConsolidadaInputModel;
using ProjetoOperacoes.InputModel.AplicacaoEmAndamentoInputModel;
using ProjetoOperacoes.InputModel.AplicacaoFutura;
using ProjetoOperacoes.InputModel.AplicacaoRealizada;
using ProjetoOperacoes.InputModel.ContaInputModel;
using ProjetoOperacoes.InputModel.TiposContaInputModel;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;

namespace ProjetoOperacoes.ViewModel
{
    public class PrincipalViewModel : BaseViewModel, IPageViewModel
    {
        private static ContaInputModel SelectedAccount = new ContaInputModel { ID = "Teste",  NomeBanco = "Teste Banco", CorHexadouble = "#00FF07", Icone = "Não tem", ValorTotal = 100000};

        private static Services ServicesPrincipalView;

        private static List<ContaInputModel> lstContas;

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
        public ObservableCollection<ContaInputModel> ListaContas { get; set; }
        public ObservableCollection<TiposContasInputModel> ListaTiposContas { get; set; }
        public ObservableCollection<AplicacaoConsolidadaInputModel> ListaConsolidada { get; set; }
        public ObservableCollection<AplicacaoFutura> ListaFutura { get; set; }
        public ObservableCollection<AplicacaoEmAndamentoInputModel> ListaEmAndamento { get; set; }
        public ObservableCollection<AplicacaoRealizada> ListaRealizada { get; set; }

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

        // Totais e Finais
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

        private double _totalComAplicacaoFuturaConsolidada;
        public double TotalComAplicacaoFuturaConsolidada
        {
            get
            {
                return _totalComAplicacaoFuturaConsolidada;
            }
            set
            {
                _totalComAplicacaoFuturaConsolidada = value;
                OnPropertyChanged("TotalComAplicacaoFuturaConsolidada");
            }

        }

        private double _totalComAplicacaoFutura;
        public double TotalComAplicacaoFutura
        {
            get
            {
                return _totalComAplicacaoFutura;
            }
            set
            {
                _totalComAplicacaoFutura = value;
                OnPropertyChanged("TotalComAplicacaoFutura");
            }

        }

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

        private double _finalTotalComAplicacaoFuturaConsolidada;
        public double FinalTotalComAplicacaoFuturaConsolidada
        {
            get
            {
                return _finalTotalComAplicacaoFuturaConsolidada;
            }
            set
            {
                _finalTotalComAplicacaoFuturaConsolidada = value;
                OnPropertyChanged("FinalTotalComAplicacaoFuturaConsolidada");
            }

        }

        private double _finalTotalComAplicacaoFutura;
        public double FinalTotalComAplicacaoFutura
        {
            get
            {
                return _finalTotalComAplicacaoFutura;
            }
            set
            {
                _finalTotalComAplicacaoFutura = value;
                OnPropertyChanged("FinalTotalComAplicacaoFutura");
            }

        }

        //Totais individuas de cada lista
        private double _totalAplicacaoFutura;
        public double TotalAplicacaoFutura
        {
            get
            {
                return _totalAplicacaoFutura;
            }
            set
            {
                _totalAplicacaoFutura = value;
                OnPropertyChanged("TotalAplicacaoFutura");
            }

        }
        #endregion

        #region Propriedades de classes de comandos
        public IrParaTipoContaCommand IrParaTipoConta { get; set; }
        public InsertNewAccountCommand InsertNewAccount { get; set; }
        public IrParaAplicacoesCommand IrParaAplicacoes { get; set; }
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

            //Instanciando Listas
            ListaContas = new ObservableCollection<ContaInputModel>();
            ListaTiposContas = new ObservableCollection<TiposContasInputModel>();
            ListaConsolidada = new ObservableCollection<AplicacaoConsolidadaInputModel>();
            ListaFutura = new ObservableCollection<AplicacaoFutura>();
            ListaEmAndamento = new ObservableCollection<AplicacaoEmAndamentoInputModel>();
            ListaRealizada = new ObservableCollection<AplicacaoRealizada>();

            //Chamando métodos
            CarregarDados();
        }
        #endregion

        #region Métodos
        private void CarregarDados()
        {
            lstContas = new List<ContaInputModel>();
            lstContas = ServicesPrincipalView.AccountsList();

            foreach (var item in lstContas)
                ListaContas.Add(new ContaInputModel(item.ID, item.NomeBanco, item.CorHexadouble, item.Icone, item.ValorTotal));
        }

        private void LimparObservableCollection()
        {
            App.PrincipalViewModel.ListaConsolidada.Clear();
            App.PrincipalViewModel.ListaFutura.Clear();
            App.PrincipalViewModel.ListaEmAndamento.Clear();
            App.PrincipalViewModel.ListaRealizada.Clear();
            App.PrincipalViewModel.ListaTiposContas.Clear();
        }
        private void LimparValoresViewModel()
        {
            App.PrincipalViewModel.TotalAtual = 0;
            App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada = 0;
            App.PrincipalViewModel.TotalComAplicacaoFutura = 0;
            App.PrincipalViewModel.FinalTotalAtual = 0;
            App.PrincipalViewModel.FinalTotalComAplicacaoFuturaConsolidada = 0;
            App.PrincipalViewModel.FinalTotalComAplicacaoFutura = 0;
        }
        #endregion

        #region Classes de Comandos
        public class IrParaAplicacoesCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                var tipoContaSelecionado = (TiposContasInputModel)parameter;

                List<AplicacaoConsolidadaInputModel> itensConsolidados = ServicesPrincipalView.ConsolidateApplicationListByIdAccountType(tipoContaSelecionado.ID);

                App.PrincipalViewModel.LimparObservableCollection();

                foreach (var item in itensConsolidados)
                    App.PrincipalViewModel.ListaConsolidada.Add(item);
            }
        }
        public class IrParaTipoContaCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                SelectedAccount = (ContaInputModel)parameter;

                var itens = ServicesPrincipalView.AccountsTypeListByIdAccount(SelectedAccount.ID);
                App.PrincipalViewModel.DadosConta = SelectedAccount.NomeBanco + "   " + SelectedAccount.ValorTotal.ToString("N2", CultureInfo.CurrentCulture);

                App.PrincipalViewModel.LimparObservableCollection();
                App.PrincipalViewModel.LimparValoresViewModel();

                foreach (var item in itens)
                    App.PrincipalViewModel.ListaTiposContas.Add(new TiposContasInputModel(item.ID, item.IdContas, item.Nome, item.TipoConta, item.QuantidadeDeAplicacao ,null, null, null, null, item.ValorTotalConta));
            }
        }
        public class InsertNewAccountCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                //var itemSelecionado = (ContaInputModel)parameter;
                ServicesPrincipalView.InsertAccount(SelectedAccount);
                App.PrincipalViewModel.ListaContas.Clear();
                App.PrincipalViewModel.CarregarDados();
            }
        }
        #endregion
    }
}
