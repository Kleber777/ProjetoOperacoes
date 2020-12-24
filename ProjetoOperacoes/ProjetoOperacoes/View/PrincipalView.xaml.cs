using ProjetoOperacoes.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace ProjetoOperacoes.View
{
    /// <summary>
    /// Interaction logic for PrincipalView.xaml
    /// </summary>
    public partial class PrincipalView : UserControl
    {
        public PrincipalView()
        {
            InitializeComponent();
            DataContext = new PrincipalViewModel();
            App.PrincipalViewModel = (PrincipalViewModel)DataContext;
        }

        private void txtbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AtualizarViewModel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
