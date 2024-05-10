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
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MaterialSearchHandler<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        WoodRepository woodRepository = new WoodRepository();
        NailRepository nailRepository = new NailRepository();
        ScrewRepository screwRepository = new ScrewRepository();

        MaterialSearchService<IEnumerable<T>> _searchService;


        public ObservableCollection<IMaterial> SearchResults { get; private set; }

        public MaterialSearchHandler()
        {
            _searchService = new MaterialSearchService<IEnumerable<T>(woodRepository, nailRepository, screwRepository);
            SearchResults = new ObservableCollection<IMaterial>();
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
