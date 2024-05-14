
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
        ProjectMakerView mainContent = new ProjectMakerView();
        private MainViewModel _mvm = new MainViewModel();
        public ProjectsView()
        {
            this.DataContext = _mvm;
            InitializeComponent();
            LoadLists();
        }

        private void LoadLists()
        {
            ProjectsListBox.ItemsSource = _mvm.ProjectsVM;
        }
        private void ProjectsListBoxFocus(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProjectsDisplayInformation();
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = mainContent;
        }
        
    }
}
