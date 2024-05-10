using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using System.Collections.ObjectModel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        private ProjectRepository projectRepo;

        

        public ProjectViewModel SelectedProject { get; set; }
        public ObservableCollection<ProjectViewModel> ProjectsVM;
        
        public MainViewModel()
        {
            projectRepo = new ProjectRepository();
            List<Project> projects = projectRepo.GetAll();
            ProjectsVM = new ObservableCollection<ProjectViewModel>(projects.Select(p => new ProjectViewModel(p)));
        }

        public void CreateProject(string title, string offer, string address, string projectDescription)
        {
            Project project = new Project(title, offer, address, projectDescription);
            projectRepo.Add(project);
            ProjectsVM.Add(new ProjectViewModel(project));
        }
        public List<Project> GetAll()
        {
            return projectRepo.GetAll();
        }
    }
}