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
    public class MaterialSearchHandler : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private IRepository<IMaterial> _woodRepository = new WoodRepository();
        private IRepository<IMaterial> _nailRepository = new NailRepository();
        private IRepository<IMaterial> _screwRepository = new ScrewRepository();

        MaterialSearchService<IMaterial> _searchService;


        public ObservableCollection<IMaterial> SearchResults { get; private set; }

        public MaterialSearchHandler()
        {
            _searchService = new MaterialSearchService<IMaterial>(_woodRepository, _nailRepository, _screwRepository);
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
