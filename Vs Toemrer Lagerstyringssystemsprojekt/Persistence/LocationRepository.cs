using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Json;
using System.Windows.Controls;
using System.Windows.Navigation;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class LocationRepository : IRepository<Location>
    {
        private List<Location> locations = new List<Location>();
        
        public LocationRepository()
        {
            InitializeRepository();
        }

        private void InitializeRepository()
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM LOCATION", connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string position = reader["Position"].ToString();

                        Location location = new Location(position);

                        locations.Add(location);
                    }
                }
            }
        }

        public Location Get(string position)
        {
            foreach (Location location in locations)
            {
                if (location.Position == position)
                    return location;
            }
            throw new ArgumentException("Location not found.");
        }

        public List<Location> GetAll()
        {
            return locations.ToList();
        }
    }
}