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
        MaterialSearchHandler msh = new MaterialSearchHandler();
        public ProjectsDisplayInformation()
        {
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {
            lbMaterialsList.ItemsSource = msh.SearchResults;

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            msh.PerformSearch(txbSearch.Text);
        }


        // Clear search box when clicked
        private void txbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txbSearch.Text == "Søg")
            {
                txbSearch.Text = "";
                txbSearch.HorizontalContentAlignment = HorizontalAlignment.Left;
            }
        }
    }
}
