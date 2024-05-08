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

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MaterialSearchViewModel : INotifyPropertyChanged
    {
        private MaterialSearchService _searchService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Material> SearchResults { get; private set; }

        MaterialSearchViewModel() 
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
