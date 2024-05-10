using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MaterialSearchHandler : INotifyPropertyChanged
    {
        WoodRepository woodRepository = new WoodRepository();
        NailRepository nailRepository = new NailRepository();
        ScrewRepository screwRepository = new ScrewRepository();


        public static MaterialSearchService _searchService;
        public ObservableCollection<Material> SearchResults { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public MaterialSearchHandler()
        {
            _searchService = new MaterialSearchService(woodRepository, nailRepository, screwRepository);
            SearchResults = new ObservableCollection<Material>();
        }

    }
}
