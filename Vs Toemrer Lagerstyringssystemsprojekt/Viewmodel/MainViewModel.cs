using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using System.Collections.ObjectModel;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ProjectViewModel SelectedProject { get; set; }

        //Repositories
        public ProjectRepository projectRepo;
        public WoodRepository woodRepo;
        public NailRepository nailRepo;
        public ScrewRepository screwRepo;

        //Observable collections
        public ObservableCollection<ProjectViewModel> ProjectsVM;
        public ObservableCollection<WoodRepository> WoodsVM;
        public ObservableCollection<NailRepository> NailsVM;
        public ObservableCollection<ScrewRepository> ScrewsVM;


        public MainViewModel()
        {
            projectRepo = new ProjectRepository();
            woodRepo = new WoodRepository();
            nailRepo = new NailRepository();
            screwRepo = new ScrewRepository();

            ProjectsVM= new ObservableCollection<ProjectViewModel>(projectRepo.GetAll().Select(project => new ProjectViewModel(project)));
            var woods = woodRepo.GetAll();

            
            //WoodsVM = new ObservableCollection<WoodViewModel>(woodRepo.GetAll().Select(wood => new WoodViewModel(wood)));
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