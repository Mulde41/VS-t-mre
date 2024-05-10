using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure
{
    // Denne klasse er en del af GRASP. Pure fabrication. man laver en klasse der ikke eksistere i domænet. det er de .9 pattern i GRASP
    public class MaterialSearchService<List>
    {
        //private WoodRepository _woodRepository;
        //private NailRepository _nailRepository;
        //private ScrewRepository _screwRepository;

        //public MaterialSearchService(WoodRepository woodRepository, NailRepository nailRepository, ScrewRepository screwRepository)
        //{
        //    _woodRepository = woodRepository;
        //    _nailRepository = nailRepository;
        //    _screwRepository = screwRepository;
        //}

        public List<List<T>> SearchMaterials<T>(IEnumerable<List<T>> source, T searchTerm)
        {
            var matchingLists = new List<List<T>>();

            foreach (var materialList in source)
            {
                if (materialList.Contains(searchTerm))
                {
                    matchingLists.Add(materialList);
                }
            }

            return matchingLists;
        }
    }
}
