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
    public class MaterialRepository
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
                SqlCommand command = new SqlCommand("SELECT * FROM MATERIAL WHERE Type = Wood", connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Wood wood = new Wood
                        (
                            reader["Sort"].ToString(),
                            reader["Type"].ToString(),
                            reader["Height"].ToString(),
                            reader["Length"].ToString(),
                            reader["Width"].ToString(),
                            // Location association
                            
                        );


                        materials.Add(wood);
                    }
                }
            }
        }
        public Material Get(string Type)
        {

        }
    }
}
