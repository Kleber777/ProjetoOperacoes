using ProjetoOperacoes.ViewModel;
using ProjetoOperacoes.ViewModel.NavigationPage;
using System.Windows;

namespace ProjetoOperacoes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();
            ApplicationPagesViewModel context = new ApplicationPagesViewModel();
            app.DataContext = context;
            ApplicationPagesViewModel = (ApplicationPagesViewModel)context;
            app.Show();
        }

        public static ApplicationPagesViewModel ApplicationPagesViewModel { get; set; }
        public static PrincipalViewModel PrincipalViewModel { get; set; }
        public static TestePageViewModel TestePageViewModel { get; set; }
        public static bool Passou = false;

    }
}
