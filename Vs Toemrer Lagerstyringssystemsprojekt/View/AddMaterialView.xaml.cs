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
using System.Windows.Shapes;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for AddMaterialView.xaml
    /// </summary>
    public partial class AddMaterialView : Window
    {
        MainViewModel mvm = new MainViewModel();
        MaterialSearchViewModel msvm = new MaterialSearchViewModel();

        public AddMaterialView(string materialName, string materialQuantity)
        {
            InitializeComponent();
            lblMaterial.Content = ;
            lblQuantity.Content = "Antal: " + msvm.SearchResults[ProjectsListView.SelectedIndex].Quantity;
        }

        
    }
}
