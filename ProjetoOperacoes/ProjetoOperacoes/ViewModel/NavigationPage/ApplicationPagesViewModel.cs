using System.Collections.Generic;
using System.Linq;

namespace ProjetoOperacoes.ViewModel.NavigationPage
{
    public class ApplicationPagesViewModel : BaseViewModel
    {
        public void FecharTodosPopus()
        {
            //Barra Menu Popups
            //App.UCBarraMenuViewModel.IsMenuLogoClienteOpen = false;
            //App.UCBarraMenuViewModel.IsMenuLogoNextOpen = false;
            //App.UCBarraMenuViewModel.IsEfetuarSangriaOpen = false;
            //App.UCBarraMenuViewModel.IsEfetuarSuprimentoOpen = false;
            //App.UCBarraMenuViewModel.IsAdicionarFundoDeCaixaOpen = false;

            ////Painel Carrinho Popups
            //App.UCPainelControleViewModel.IsOpcoesOpen = false;
            //App.UCPainelControleViewModel.IsAlterarQuantidadeOpen = false;
            //App.UCPainelControleViewModel.IsAdicionarComplementoOpen = false;
            //App.UCPainelControleViewModel.IsAdicionarDescontoPercentualOpen = false;
            //App.UCPainelControleViewModel.IsAdicionarDescontoValorOpen = false;

            //    //Menu PagamentoViewModel Popups
            //    App.PagamentoViewModel.IsOpen = false;
        }

        public void AtivarOpacity()
        {
            //App.ApplicationPagesViewModel.Opacity = 0.5;
        }

        public void DesativarOpacity()
        {
            //App.ApplicationPagesViewModel.Opacity = 1;
        }

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        private double _opacity;
        private bool _fecharPopClick;
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        public bool FecharPopClick
        {
            get
            {
                return _fecharPopClick;
            }
            set
            {
                _fecharPopClick = value;
                OnPropertyChanged("FecharPopClick");
            }
        }
        public double Opacity
        {
            get
            {
                return _opacity;
            }
            set
            {
                _opacity = value;
                OnPropertyChanged("Opacity");
            }
        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }
        //private void OnGoOperadorDeCaixaView(object obj)
        //{
        //    ChangeViewModel(PageViewModels[Paginas.OperadorView]);
        //}
        //private void OnGoAbrirPDVView(object obj)
        //{
        //    ChangeViewModel(PageViewModels[Paginas.AbrirPDVView]);
        //}
        //private void OnGoMesaView(object obj)
        //{
        //    ChangeViewModel(PageViewModels[Paginas.MesaView]);
        //}
        private void OnGoPrincipalView(object obj)
        {
            ChangeViewModel(PageViewModels[Paginas.PrincipalView]);
        }
        private void OnGoTestePage(object obj)
        {
            ChangeViewModel(PageViewModels[Paginas.TestePageView]);
        }

        public ApplicationPagesViewModel()
        {
            //App.UCPainelControleViewModel = new UserControls.PainelCarrinho.UCPainelCarrinhoControleViewModel();

            Opacity = 1;
            FecharPopClick = true;

            // Add available pages and set page
            //PageViewModels.Add(new OperadorDeCaixaViewModel.OperadorDeCaixaViewModel());
            //PageViewModels.Add(new AbrirPDVViewModel());
            //PageViewModels.Add(new MesaViewModel.MesaViewModel());
            PageViewModels.Add(new PrincipalViewModel());
            PageViewModels.Add(new TestePageViewModel());


            CurrentPageViewModel = PageViewModels[Paginas.PrincipalView];

            //Mediator.Subscribe("GoToOperadorDeCaixaView", OnGoOperadorDeCaixaView);
            //Mediator.Subscribe("GoToAbrirPDVView", OnGoAbrirPDVView);
            //Mediator.Subscribe("GoToMesaView", OnGoMesaView);
            Mediator.Subscribe("GoToPrincipalView", OnGoPrincipalView);
            Mediator.Subscribe("GoToTestePage", OnGoTestePage);
        }
    }
}
