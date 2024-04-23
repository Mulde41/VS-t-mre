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

        private void btnTree_Click(object sender, RoutedEventArgs e)
        {
            ClearMainWindow();
            PopulateItems();
           
        }

        private void ClearMainWindow()
        {
            btnTree.Visibility = Visibility.Collapsed;
            lbTree.Visibility = Visibility.Visible;
            lbTree.Items.Clear();
        }

        private void PopulateItems()
        {
            List<string> tree = new List<string>
            {
                "tree 1",
                "tree 2",
                "tree 3"
            };

            foreach (string item in tree)
            {
                lbTree.Items.Add(item);
            }

        }
    }
}