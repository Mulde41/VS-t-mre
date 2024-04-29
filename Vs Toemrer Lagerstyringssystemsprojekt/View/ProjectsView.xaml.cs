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
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : UserControl
    {
        WoodRepository wr = new WoodRepository();
        public ProjectsView()
        {
            InitializeComponent();
            LoadMaterials();
        }
        private void LoadMaterials()
        {
            //    var materials = new List<Material>
            //{
            //    new Wood ("Fyrretræ", "Reglar", "Olieret", 20.0, 200.0, 25.0, 50),
            //    new Wood ("Piktræ", "phallus", "Olieret", .0, 10.0, 3.0, 5000),
            //    new Wood ("Fyrretræ", "Reglar", "Olieret", 20.0, 230.0, 25.0, 50),
            //};

            MaterialsListView.ItemsSource = wr.wood_Materials;
        }
    }
}
