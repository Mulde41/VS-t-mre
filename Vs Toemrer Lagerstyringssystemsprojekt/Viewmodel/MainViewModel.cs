using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ProjectRepository projectRepo;
        public MainViewModel(ProjectRepository projectRepository) // DEPENDENCY INJECTION, add more repositories as more are needed
        {
            projectRepo = projectRepository;
        }

        public void AddProject(string title, double offer, string address, string projectDescription)
        {
            Project project = new Project(title, offer, address, projectDescription);
            projectRepo.Add(project);
        }
    }
}