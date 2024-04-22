using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class LocationRepository : IRepository<Location>
    {
        private List<Location> _locations = new List<Location>();

        public LocationRepository()
        {
            InitializeRepository();
        }

        private void InitializeRepository()
        {
            throw new NotImplementedException();
        }

        public Location Get(Location location)
        {
            foreach (Location loc in _locations)
            {
                if (loc.Position == location.Position)
                    return loc;
            }
            throw new ArgumentException("Location not found or is null");
        }
        public List<Location> GetAll()
        {
            return _locations.ToList();
        }
    }
}
