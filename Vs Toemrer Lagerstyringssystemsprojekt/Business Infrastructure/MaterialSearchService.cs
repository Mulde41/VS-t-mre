using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure
{
    // Denne klasse er en del af GRASP. Pure fabrication. man laver en klasse der ikke eksistere i domænet. det er de .9 pattern i GRASP
    public class MaterialSearchService<T>
    {
        private IRepository<T> _repository1;
        private IRepository<T> _repository2;
        private IRepository<T> _repository3;

        public MaterialSearchService(IRepository<T> repository1, IRepository<T> repository2, IRepository<T> repository3)
        {
            _repository1 = repository1;
            _repository2 = repository2;
            _repository3 = repository3;
        }

        public IEnumerable<T> SearchMaterials(string searchTerm)
        {
            var items1 = _repository1.Get(searchTerm);
            var items2 = _repository2.Get(searchTerm);
            var items3 = _repository3.Get(searchTerm);

            // Combine all results into a single list
            return items1.Concat(items2).Concat(items3);
        }
    }
}
