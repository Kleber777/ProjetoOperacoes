using ProjetoOperacoes.EntityFramework;
using ProjetoOperacoes.InputModel.AplicacaoConsolidadaInputModel;
using ProjetoOperacoes.InputModel.AplicacaoEmAndamentoInputModel;
using ProjetoOperacoes.InputModel.AplicacaoFutura;
using ProjetoOperacoes.InputModel.AplicacaoRealizada;
using ProjetoOperacoes.InputModel.ContaInputModel;
using ProjetoOperacoes.InputModel.TiposContaInputModel;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ProjetoOperacoes.ViewModel
{
    public class PrincipalViewModel : BaseViewModel, IPageViewModel
    {
        #region Operacao isso vai sair daqui
        //ID CONTAS
        private string idContaItau = "f1c67966-44f5-42a4-9234-f98de19ee091";
        private string idContaMercadoPago = "f0062c82-a2b4-4d1f-8def-a9bd2546d322";
        private string idContaPagSeguro = "8ba15d50-c8c3-4381-bbe2-e34bdbe03113";
        private string idContaPicPay = "7889eb71-e59c-422a-8ae6-698e1a678203";
        private string idContaUndefinied = "85c40d81-e63f-46a4-bade-c5bcdf130789";

        //ID TIPOS CONTAS
        private string idContaCorrenteItau = "15fdda04-7326-4f91-8cac-928708920710";
        private string idContaPoupancaItau = "d36da50d-9ee4-41f2-89d8-5cb7d146e343";
        private string idContaCorrenteMercadoPago = "d18ad537-dcc3-4031-9331-da1c4938308f";
        private string idContaCorrentePagSeguro = "c09d5e46-f13e-4e8c-8214-334b6782422c";
        private string idContaCorrentePicPay = "9cbedd4f-9bb8-4622-85c9-b5d1182ff867";
        private string idContaCorrenteUndefinied = "b79efaec-b023-463d-895a-286d80afc690";

        private static List<ContaInputModel> lstContas;
        private static List<TiposContasInputModel> lstTiposContas;
        private static List<AplicacaoConsolidadaInputModel> lstAplicacaoConsolidada;
        private static List<AplicacaoEmAndamentoInputModel> lstAplicacaoEmAndamento;
        private static List<AplicacaoRealizada> lstAplicacaoRealizada;
        private static List<AplicacaoFutura> lstAplicacaoFutura;
        #endregion

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
        private decimal _totalAtual;
        public decimal TotalAtual
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

        private decimal _totalComAplicacaoFuturaConsolidada;
        public decimal TotalComAplicacaoFuturaConsolidada
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

        private decimal _totalComAplicacaoFutura;
        public decimal TotalComAplicacaoFutura
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

        private decimal _finalTotalAtual;
        public decimal FinalTotalAtual
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

        private decimal _finalTotalComAplicacaoFuturaConsolidada;
        public decimal FinalTotalComAplicacaoFuturaConsolidada
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

        private decimal _finalTotalComAplicacaoFutura;
        public decimal FinalTotalComAplicacaoFutura
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
        private decimal _totalAplicacaoFutura;
        public decimal TotalAplicacaoFutura
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
        public IrParaAplicacoesCommand IrParaAplicacoes { get; set; }
        #endregion

        #region Construtores
        public PrincipalViewModel()
        {
            //Instanciando Commands
            IrParaTipoConta = new IrParaTipoContaCommand();
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
            //using (var db = new ApplicationDBContext())
            //{
            //    var lstContas = db.AccountsDbSet.ToList();

            //}

            CarregarContasConsolidadas();
            CarregarContasFuturas();
            CarregarContasEmAndamento();
            CarregarContasRealizadas();
            CarregarTiposContas();
            CarregarContas();
        }
        private void CarregarContas()
        {
            try
            {
                var TotalContaItau = 0M;
                var TotalContaMercadoPago = 0M;
                var TotalContaPagSeguro = 0M;
                var TotalContaPicPay = 0M;

                var index = lstTiposContas.FindAll(x => x.IdContas == idContaItau).Count;
                for (int i = 0; i < index; i++)
                    TotalContaItau += lstTiposContas.FindAll(x => x.IdContas == idContaItau)[i].ValorTotalConta;

                index = lstTiposContas.FindAll(x => x.IdContas == idContaMercadoPago).Count;
                for (int i = 0; i < index; i++)
                    TotalContaMercadoPago += lstTiposContas.FindAll(x => x.IdContas == idContaMercadoPago)[i].ValorTotalConta;

                index = lstTiposContas.FindAll(x => x.IdContas == idContaPagSeguro).Count;
                for (int i = 0; i < index; i++)
                    TotalContaPagSeguro += lstTiposContas.FindAll(x => x.IdContas == idContaPagSeguro)[i].ValorTotalConta;

                index = lstTiposContas.FindAll(x => x.IdContas == idContaPicPay).Count;
                for (int i = 0; i < index; i++)
                    TotalContaPicPay += lstTiposContas.FindAll(x => x.IdContas == idContaPicPay)[i].ValorTotalConta;

                lstContas = new List<ContaInputModel>()
                {
                    new ContaInputModel(idContaItau, "Itaú", "#EC7000", "../Images/Itau.png" , TotalContaItau),
                    new ContaInputModel(idContaMercadoPago, "Mercado Pago", "#009FE3", "../Images/MercadoPago.png", TotalContaMercadoPago),
                    new ContaInputModel(idContaPagSeguro, "PagSeguro", "#5CBD4C", "../Images/PagSeguro.png", TotalContaPagSeguro),
                    new ContaInputModel(idContaPicPay, "PicPay", "#11C770", "../Images/PicPay.png", TotalContaPicPay),
                    new ContaInputModel(idContaUndefinied, "Undefinied", "#0000FF", "Icons/PicPay.png", 200)
                };
                foreach (var item in lstContas)
                {
                    ListaContas.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarregarTiposContas()
        {
            try
            {
                lstTiposContas = new List<TiposContasInputModel>()
                {
                    new TiposContasInputModel(idContaCorrenteItau, idContaItau, "Conta Corrente", 1, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaCorrenteItau), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaCorrenteItau), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaCorrenteItau), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaCorrenteItau), 5196.80M),
                    new TiposContasInputModel(idContaPoupancaItau, idContaItau, "Conta Poupança", 2, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaPoupancaItau), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaPoupancaItau), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaPoupancaItau), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaPoupancaItau), 7080M),
                    new TiposContasInputModel(idContaCorrenteMercadoPago , idContaMercadoPago, "Conta Corrente", 1, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaCorrenteMercadoPago), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaCorrenteMercadoPago), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaCorrenteMercadoPago), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaCorrenteMercadoPago), 1369.55M),
                    new TiposContasInputModel(idContaCorrentePagSeguro, idContaPagSeguro, "Conta Corrente", 1, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaCorrentePagSeguro), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaCorrentePagSeguro), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaCorrentePagSeguro), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaCorrentePagSeguro), 614.68M),
                    new TiposContasInputModel(idContaCorrentePicPay, idContaPicPay, "Conta Corrente", 1, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaCorrentePicPay), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaCorrentePicPay), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaCorrentePicPay), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaCorrentePicPay), 0M),
                    new TiposContasInputModel(idContaCorrenteUndefinied, idContaUndefinied, "Conta Corrente", 1, lstAplicacaoConsolidada.FindAll(x => x.IdTiposContas == idContaCorrenteUndefinied), lstAplicacaoFutura.FindAll(x => x.IdTiposContas == idContaCorrenteUndefinied), lstAplicacaoEmAndamento.FindAll(x => x.IdTiposContas == idContaCorrenteUndefinied), lstAplicacaoRealizada.FindAll(x => x.IdTiposContas == idContaCorrenteUndefinied), 0M),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarregarContasConsolidadas()
        {
            try
            {
                lstAplicacaoConsolidada = new List<AplicacaoConsolidadaInputModel>()
                {
                    //ITAÚ 
                    new AplicacaoConsolidadaInputModel("430fc1a3-8da7-462d-a8d8-4ce6f2039055", idContaCorrenteItau, "Dinheiro separado para calistenia", 1, 1000.00M, 1000.00M),
                    new AplicacaoConsolidadaInputModel("b4af54b4-449e-419f-8aa6-830b52e50430", idContaCorrenteItau, "Roupas", 1, 1000.00M, 1000.00M),
                    new AplicacaoConsolidadaInputModel("49071a38-819d-49de-89af-f6e019160e9b", idContaCorrenteItau, "Mensalidade Itaú", 13, 28.90M, 346.80M),
                    new AplicacaoConsolidadaInputModel("49071a38-819d-49de-89af-f6e019160e9b", idContaCorrenteItau, "Dinheiro separado para CNH", 1, 2000M, 2000M),

                    //MERCADO PAGO
                   new AplicacaoConsolidadaInputModel("49071a38-819d-49de-89af-f6e019160e9b", idContaCorrenteMercadoPago, "Mensalidade WiseUp", 12, 85, 850M),
                   new AplicacaoConsolidadaInputModel("49071a38-819d-49de-89af-f6e019160e9b", idContaCorrenteMercadoPago, "Conta Premium LinkedIn", 1, 360, 360),
                   

                    //PAGSEGURO
                    new AplicacaoConsolidadaInputModel("57197f9b-1239-40ee-9316-36432232a92f", idContaCorrentePagSeguro, "Plano Oi", 12, 30, 360),
                    new AplicacaoConsolidadaInputModel("57197f9b-1239-40ee-9316-36432232a92f", idContaCorrentePagSeguro, "Dinheiro para colocar no Bilhete único", 1, 54.68M, 54.68M),
                    new AplicacaoConsolidadaInputModel("57197f9b-1239-40ee-9316-36432232a92f", idContaCorrentePagSeguro, "Dinheiro para volta a Next", 1, 200M, 200M)

                    //PICPAY

                    //UNDEFINIED
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarregarContasFuturas()
        {
            try
            {
                lstAplicacaoFutura = new List<AplicacaoFutura>()
                {
                    //ITAÚ CONTA POUPANCA
                    new AplicacaoFutura("5b06f961-8456-4c9b-9406-654a68475cb5", idContaPoupancaItau, "Separar possível dinheiro para o Bilhete Mensal", 12, 340, 4080),

                    //ITAÚ CONTA CORRENTE
                    new AplicacaoFutura("5b06f961-8456-4c9b-9406-654a68475cb5", idContaCorrenteItau, "Dinheiro para comprar o guarda-roupas", 1, 1500, 1500),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarregarContasEmAndamento()
        {
            try
            {
                lstAplicacaoEmAndamento = new List<AplicacaoEmAndamentoInputModel>()
                {
                    new AplicacaoEmAndamentoInputModel("49071a38-819d-49de-89af-f6e019160e9b", idContaCorrenteItau, "Mensalidade Itaú", 13, 28.90M, 346.80M),
                    new AplicacaoEmAndamentoInputModel("57197f9b-1239-40ee-9316-36432232a92f", idContaCorrentePagSeguro, "Plano Oi", 12, 30, 360),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CarregarContasRealizadas()
        {
            try
            {
                lstAplicacaoRealizada = new List<AplicacaoRealizada>()
                {
                    new AplicacaoRealizada("430fc1a3-8da7-462d-a8d8-4ce6f2039055", idContaMercadoPago, "C e SBC", 1, 214.00M, 214.00M),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                var itemSelecionado = (TiposContasInputModel)parameter;

                App.PrincipalViewModel.ListaConsolidada.Clear();
                foreach (var item in itemSelecionado.ItensConsolidados)
                    App.PrincipalViewModel.ListaConsolidada.Add(item);

                App.PrincipalViewModel.ListaFutura.Clear();
                foreach (var item in itemSelecionado.ItensFuturos)
                    App.PrincipalViewModel.ListaFutura.Add(item);

                App.PrincipalViewModel.ListaEmAndamento.Clear();
                foreach (var item in itemSelecionado.ItensEmAndamento)
                    App.PrincipalViewModel.ListaEmAndamento.Add(item);

                App.PrincipalViewModel.ListaRealizada.Clear();
                foreach (var item in itemSelecionado.ItensRealizados)
                    App.PrincipalViewModel.ListaRealizada.Add(item);

                App.PrincipalViewModel.LimparValoresViewModel();
                decimal descontar = 0;

                //Calculando o total sem os itens em andamentos
                for (int i = 0; i < itemSelecionado.ItensEmAndamento.Count; i++)
                    descontar += itemSelecionado.ItensEmAndamento.FindAll(x => x.IdTiposContas == itemSelecionado.ID)[i].ValorTotal;

                for (int i = 0; i < itemSelecionado.ItensConsolidados.Count; i++)
                    App.PrincipalViewModel.TotalAtual += itemSelecionado.ItensConsolidados.FindAll(x => x.IdTiposContas == itemSelecionado.ID)[i].ValorTotal;

                App.PrincipalViewModel.TotalAtual -= descontar;

                //Calculando o total com aplicação futura consolidada
                for (int i = 0; i < itemSelecionado.ItensConsolidados.Count; i++)
                    App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada += itemSelecionado.ItensConsolidados.FindAll(x => x.IdTiposContas == itemSelecionado.ID)[i].ValorTotal;

                //Calculando o total com aplicação futura
                for (int i = 0; i < itemSelecionado.ItensFuturos.Count; i++)
                    App.PrincipalViewModel.TotalComAplicacaoFutura += itemSelecionado.ItensFuturos.FindAll(x => x.IdTiposContas == itemSelecionado.ID)[i].ValorTotal;

                App.PrincipalViewModel.TotalAplicacaoFutura = App.PrincipalViewModel.TotalComAplicacaoFutura;
                App.PrincipalViewModel.TotalComAplicacaoFutura += itemSelecionado.ItensFuturos.Count == 0 ? 0 : App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada;

                App.PrincipalViewModel.FinalTotalAtual = itemSelecionado.ValorTotalConta - App.PrincipalViewModel.TotalAtual;
                App.PrincipalViewModel.FinalTotalComAplicacaoFuturaConsolidada = itemSelecionado.ValorTotalConta - App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada;

                /* O App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada é o valor de todo o futuro exato! Por isso devemos subtrair por ele quanto o count da 
                 ItensFuturos for igual a zero */
                App.PrincipalViewModel.FinalTotalComAplicacaoFutura = itemSelecionado.ItensFuturos.Count == 0 ?
                    itemSelecionado.ValorTotalConta - App.PrincipalViewModel.TotalComAplicacaoFuturaConsolidada : itemSelecionado.ValorTotalConta - App.PrincipalViewModel.TotalComAplicacaoFutura;
            }
        }
        public class IrParaTipoContaCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                var itemSelecionado = (ContaInputModel)parameter;
                App.PrincipalViewModel.DadosConta = itemSelecionado.NomeBanco + "   " + itemSelecionado.ValorTotal.ToString("N2", CultureInfo.CurrentCulture);

                var itens = lstTiposContas.FindAll(x => x.IdContas == itemSelecionado.ID);

                App.PrincipalViewModel.ListaConsolidada.Clear();
                App.PrincipalViewModel.ListaFutura.Clear();
                App.PrincipalViewModel.ListaEmAndamento.Clear();
                App.PrincipalViewModel.ListaRealizada.Clear();
                App.PrincipalViewModel.ListaTiposContas.Clear();
                App.PrincipalViewModel.LimparValoresViewModel();

                foreach (var item in itens)
                    App.PrincipalViewModel.ListaTiposContas.Add(item);
            }
        }
        #endregion
    }
}
