using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ProjectViewModel : INotifyPropertyChanged
    {
        public Project SelectedProject { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        private ProjectRepository projectRepo;
        public ObservableCollection<Project> ProjectsVM;
        public ProjectViewModel(/*ProjectRepository repository*/) 
        {
            projectRepo = new ProjectRepository();
            ProjectsVM = new ObservableCollection<Project>(projectRepo.GetAll());
        }

        public void CreateProject(string title, double offer, string address, string projectDescription)
        {
            Project project = new Project(title, offer, address, projectDescription);
            //projectRepo.Add(project);
            //ProjectsVM.Add(project);
        }
        public List<Project> GetAll()
        {
            return projectRepo.GetAll();
        }
        
    }
}
