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
using Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    public partial class ProjectsDisplayInformation : UserControl
    {
        MainViewModel mvm = new MainViewModel();
        MaterialSearchService mss;
        public ProjectsDisplayInformation()
        {
            this.DataContext = mvm;
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {
            ProjectsListView.ItemsSource = mss.SearchResults;
            
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            mss.PerformSearch(txbSearchbar.Text);
        }

        private void txbSeachbar_GotFocus(object sender, RoutedEventArgs e)
        {
            txbSearchbar.Text = "";
        }

        private void ProjectsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblMaterialName.Content = "Materiale: " + mss.SearchResults[ProjectsListView.SelectedIndex].Name;
            lblMaterialQuantity.Content = "Antal: " + mss.SearchResults[ProjectsListView.SelectedIndex].Quantity;
        }

        private void ProjectsListView_GotFocus(object sender, RoutedEventArgs e)
        {
            AddMaterialView addMaterialViewWindow = new AddMaterialView();
            addMaterialViewWindow.Show();
        }
    }
}
