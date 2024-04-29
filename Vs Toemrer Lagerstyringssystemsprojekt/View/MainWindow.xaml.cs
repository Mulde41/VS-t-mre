using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vs_Toemrer_Lagerstyringssystemsprojekt.View;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lager_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new StorageView();
        }

        private void Projekter_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProjectsView();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}