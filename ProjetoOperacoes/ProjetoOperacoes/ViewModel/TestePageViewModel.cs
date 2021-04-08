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
        public SaveApplicationCommand SaveApplication { get; set; }
        public TestePageViewModel()
        {
            Visibility = "Hidden";

            //Instanciando os comandos
            CancelApplication = new CancelApplicationCommand();
            SaveApplication = new SaveApplicationCommand();
        }

        public class CancelApplicationCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
               
            }
        }
        public class SaveApplicationCommand : BaseCommand
        {
            public override void Execute(object parameter)
            {
                ApplicationBuilder builder = new ApplicationBuilder();
                Director director = new Director(builder);

                if (App.TestePageViewModel.IsConsolidated)
                {
                    director.CreateConsolidatedApplication(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                           App.TestePageViewModel.Description,
                                                           Convert.ToDouble(App.TestePageViewModel.IndividualValue));
                }
                else
                {
                    director.CreateFutureApplication(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                     App.TestePageViewModel.Description,
                                                     Convert.ToDouble(App.TestePageViewModel.IndividualValue));

                }

                // Aqui ele reseta a aplicação e não o RepeteadId
                var model = builder.GetApplication();

                // Passar a model para o banco Db.SaveChanges(model);
                ServicesApplication.CreateApplication(model);

                if (App.TestePageViewModel.HadInstallments)
                {
                    director.CreateApplicationWithInstallments(App.PrincipalViewModel.AccountTypeSelected.ID,
                                                               App.TestePageViewModel.Description,
                                                               Convert.ToInt32(App.TestePageViewModel.CountInstallments),
                                                               Convert.ToDouble(App.TestePageViewModel.IndividualValue));

                    var modelWithInstallments = builder.GetApplication();

                    // Passar a model para o banco Db.SaveChanges(modelWithInstallments);
                    ServicesApplication.CreateApplication(modelWithInstallments);

                }
            }
        }
    }
}
