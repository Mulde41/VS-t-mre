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
    public class MaterialSearchViewModel : INotifyPropertyChanged
    {
        WoodRepository woodRepository = new WoodRepository();
        NailRepository nailRepository = new NailRepository();
        ScrewRepository screwRepository = new ScrewRepository();
        private MaterialSearchService<ScrewRepository> _searchService = new MaterialSearchService<ScrewRepository>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Material> SearchResults { get; private set; }

        public MaterialSearchViewModel()
        {
            //_searchService = new MaterialSearchService(woodRepository, nailRepository, screwRepository);
            SearchResults = new ObservableCollection<Material>();
        }

        public void PerformSeach(string searchTerm)
        {
            var woodMaterials = _searchService.SearchMaterials(woodRepository.GetAll().Select(wood => wood.Name), searchTerm);
            var nailMaterials = _searchService.SearchMaterials(nailRepository.GetAll().Select(nail => nail.Name), searchTerm);
            var screwMaterials = _searchService.SearchMaterials(screwRepository.GetAll().Select(screw => screw.Name), searchTerm);
        }



        //public void PerformSearch(string searchParameter)
        //{
        //    var results = _searchService.SearchMaterials(searchParameter);
        //    SearchResults.Clear();
        //    foreach (var item in results)
        //    {
        //        SearchResults.Add(item);
        //    }
        //}
    }
}
