using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Microsoft.Extensions.Configuration.Json;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class MaterialRepository : IRepository<Material>
    {
        private List<Material> materials = new List<Material>();

        public MaterialRepository()
        {
            InitializeRepository();
        }
        private void InitializeRepository()
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM WOOD", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Wood wood = new Wood
                        (
                            reader["Sort"].ToString(),
                            reader["Type"].ToString(),
                            Convert.ToDouble(reader["Height"].ToString),
                            Convert.ToDouble(reader["Length"].ToString),
                            Convert.ToDouble(reader["Width"].ToString)
                        );
                        materials.Add(wood);
                    }
                }
            }
        }

        public Material Get(Material t)
        {
            throw new NotImplementedException();
        }

        List<Material> IRepository<Material>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
