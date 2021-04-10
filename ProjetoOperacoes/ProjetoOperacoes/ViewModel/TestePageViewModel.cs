using ProjetoOperacoes.Comandos.ApplicationCommands;
using ProjetoOperacoes.Models.ApplicationsModels.Builders;
using ProjetoOperacoes.Models.ApplicationsModels.Directors;
using ProjetoOperacoes.Services.ApplicationServices;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System;

namespace ProjetoOperacoes.ViewModel
{
    public class TestePageViewModel : BaseViewModel, IPageViewModel
    {
        private bool _isConsolidated;
        public bool IsConsolidated
        {
            get
            {
                return _isConsolidated;
            }
            set
            {
                _isConsolidated = value;
                OnPropertyChanged("IsConsolidated");
            }

        }

        private bool _isFuture;
        public bool IsFuture
        {
            get
            {
                return _isFuture;
            }
            set
            {
                _isFuture = value;
                OnPropertyChanged("IsFuture");
            }

        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }

        }

        private string _individualValue;
        public string IndividualValue
        {
            get
            {
                return _individualValue;
            }
            set
            {
                _individualValue = value;
                OnPropertyChanged("IndividualValue");
            }

        }

        private bool _hadInstallments;
        public bool HadInstallments
        {
            get
            {
                return _hadInstallments;
            }
            set
            {
                if (Visibility == "Hidden")
                    Visibility = "Visible";
                else
                    Visibility = "Hidden";

                _hadInstallments = value;
                OnPropertyChanged("HadInstallments");
            }

        }

        private string _countInstallments;
        public string CountInstallments
        {
            get
            {
                return _countInstallments;
            }
            set
            {

                _countInstallments = value;
                OnPropertyChanged("CountInstallments");
            }

        }

        private string _visibility;
        public string Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
                OnPropertyChanged("Visibility");
            }

        }

        public CancelApplicationCommand CancelApplication { get; set; }
        public CreateApplicationCommand CreateApplication { get; set; }
        public TestePageViewModel()
        {
            Visibility = "Hidden";

            //Instanciando os comandos
            CancelApplication = new CancelApplicationCommand();
            CreateApplication = new CreateApplicationCommand();
        }

        public class CancelApplicationCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                App.ApplicationPagesViewModel.CurrentPageViewModel = App.ApplicationPagesViewModel.PageViewModels[Paginas.PrincipalView];
                App.PrincipalViewModel.ApplicationSelected = null;
            }
        }
    }
}
