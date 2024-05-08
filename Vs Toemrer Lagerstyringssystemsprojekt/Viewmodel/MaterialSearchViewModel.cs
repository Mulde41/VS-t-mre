using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MaterialSearchViewModel : INotifyPropertyChanged
    {
        WoodRepository woodRepository = new WoodRepository();
        NailRepository nailRepository = new NailRepository();
        ScrewRepository screwRepository = new ScrewRepository();
        MaterialSearchService _searchService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Material> SearchResults { get; private set; }

        public MaterialSearchViewModel()
        {
            SearchResults = new ObservableCollection<Material>();
        }
        public void PerformSearch(string searchParameter)
        {
            var results = _searchService.SearchMaterials(searchParameter);
            SearchResults.Clear();
            foreach (var item in results)
            {
                SearchResults.Add(item);
            }

        }
    }
}
