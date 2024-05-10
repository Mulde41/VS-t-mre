using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectsDisplayInformation.xaml
    /// </summary>
    public partial class ProjectsDisplayInformation : UserControl
    {
       
        MainViewModel mvm = new MainViewModel();
        MaterialSearchViewModel msvm = new MaterialSearchViewModel();
        public ProjectsDisplayInformation()
        {
            //this.DataContext = msvm;
            //this.DataContext = mvm;
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {
            //MaterialsList.ItemsSource = msvm.SearchResults;
            ProjectsListView.ItemsSource = msvm.SearchResults;

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            msvm.PerformSearch(txbSeachbar.Text);
        }

        private void txbSeachbar_GotFocus(object sender, RoutedEventArgs e)
        {
            txbSeachbar.Text = "";
        }

        private void ProjectsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblMaterialName.Content = "Materiale: " + msvm.SearchResults[ProjectsListView.SelectedIndex].Name;
            lblMaterialQuantity.Content = "Antal: " + msvm.SearchResults[ProjectsListView.SelectedIndex].Quantity;
        }
    }
}
