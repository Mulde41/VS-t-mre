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
        //WoodRepository wr = new WoodRepository();
        public ProjectsView()
        {
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {
            //    var materials = new List<Material>
            //{
            //    new Wood ("Fyrretræ", "Reglar", "Olieret", 20.0, 200.0, 25.0, 50),
            //    new Wood ("Piktræ", "phallus", "Olieret", .0, 10.0, 3.0, 5000),
            //    new Wood ("Fyrretræ", "Reglar", "Olieret", 20.0, 230.0, 25.0, 50),
            //};

        List<Project> projects = new List<Project> 
        { 
            new Project("Føtex tag", 5000.0, "Vestergade 12","der skal laves et tag på den nye føtex bygning på vestergade 12"),
            new Project("City Park Renovation", 20000.0, "Main Street Park", "This project involves a full renovation of Main Street Park, including landscaping, playground installation, and park facilities upgrades."),
            new Project("Library Expansion", 15000.0, "Central Library, Elm Street", "The Central Library is expanding with a new wing to house additional collections, reading rooms, and a community space.")
        };
            ProjectsListBox.ItemsSource = projects.
        }
        
    }
}
