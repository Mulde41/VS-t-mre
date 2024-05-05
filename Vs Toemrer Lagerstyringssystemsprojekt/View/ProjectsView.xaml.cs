
using System.Windows;
using System.Windows.Controls;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : UserControl
    {
        private MainViewModel mvm = new MainViewModel();
        //private ProjectViewModel pvm = new ProjectViewModel();
        ProjectMakerView mainContent = new ProjectMakerView();
        public ProjectsView()
        {
            this.DataContext = mvm;
            //this.DataContext = pvm;
            InitializeComponent();
            LoadLists();
        }


        private void LoadLists()
        {
            ProjectsListBox.ItemsSource = mvm.GetAll();
            //ProjectsListBox.ItemsSource = pvm.GetAll();
        }
        private void ProjectsListBoxFocus(object sender, RoutedEventArgs e)
        {
            //ProjectsListBox.SelectedItem = SelectedProject;
            MainContent.Content = new ProjectsDisplayInformation();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = mainContent;
        }
        
    }
}
