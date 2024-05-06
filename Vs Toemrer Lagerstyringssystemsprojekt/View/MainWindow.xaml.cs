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
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.View;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new MainViewModel();   
        public MainWindow()
        {
            this.DataContext = mvm;
            InitializeComponent();
        }


        private void Projects_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProjectsView();
        }

        private void Storage_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new StorageView();
        }

        private void Registry_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}