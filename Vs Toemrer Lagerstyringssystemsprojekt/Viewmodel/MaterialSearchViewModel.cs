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
        public event PropertyChangedEventHandler? PropertyChanged;
        private MaterialSearchService _searchService;
        public ObservableCollection<Material> Materials { get; private set; }
        public ICommand SearchCommand { get; private set; }
        private string _searchTerm;


        public string SearchTerm
        {
            get => _searchTerm;
            set
            {
                _searchTerm = value;
                OnPropertyChanged(nameof(SearchTerm));
            }
        }

        public MaterialSearchViewModel(MaterialSearchService searchService)
        {
            _searchService = searchService;
            Materials = new ObservableCollection<Material>();
            SearchCommand = new RelayCommand(PerformSearch);
        }

        private void PerformSearch()
        {
            Materials.Clear();
            var results = _searchService.SearchMaterials(SearchTerm);
            foreach (var material in results)
            {
                Materials.Add(material);
            }
        }
    }
}
