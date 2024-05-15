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
        public ProjectRepository _projectRepo;
        public WoodRepository _woodRepo;
        public NailRepository _nailRepo;
        public ScrewRepository _screwRepo;

        //Observable collections
        public ObservableCollection<ProjectViewModel> ProjectsVM;
        public ObservableCollection<WoodViewModel> WoodsVM;
        public ObservableCollection<NailViewModel> NailsVM;
        public ObservableCollection<ScrewViewModel> ScrewsVM;


        public MainViewModel()
        {
            //Repo instantiation
            _projectRepo = ProjectRepository.Instance;
            _woodRepo = WoodRepository.Instance;
            _nailRepo = NailRepository.Instance;
            _screwRepo = ScrewRepository.Instance;

            //VM lists
            ProjectsVM= new ObservableCollection<ProjectViewModel>(_projectRepo.GetAll().Select(project => new ProjectViewModel(project)));
            WoodsVM = new ObservableCollection<WoodViewModel>(_woodRepo.GetAll().Select(wood => new WoodViewModel(wood)));
            NailsVM = new ObservableCollection<NailViewModel>(_nailRepo.GetAll().Select(nail => new NailViewModel(nail)));
            ScrewsVM = new ObservableCollection<ScrewViewModel>(_screwRepo.GetAll().Select(screw => new ScrewViewModel(screw)));
        }

        public void CreateProject(string title, string offer, string address, string projectDescription)
        {
            Project project = new Project(title, offer, address, projectDescription);
            _projectRepo.Add(project);
            ProjectsVM.Add(new ProjectViewModel(project));
        }
        public List<Project> GetAll()
        {
            return _projectRepo.GetAll();
        }
    }
}