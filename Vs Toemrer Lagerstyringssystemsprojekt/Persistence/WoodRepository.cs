using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class WoodRepository : IRepository<Wood>
    {


        public List<Wood> wood_Materials = new List<Wood>();

        public WoodRepository()
        {
            InitializeRepository();
        }


        private void InitializeRepository()
        {
            using (SqlConnection connection = new SqlConnection("Server=10.56.8.35; Database=P3_DB_2024_07; User Id=P3_PROJECT_USER_2024_07; Password=OPENDB_07; TrustServerCertificate=true"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Sort, Type, Height, Length, Width, Quantity, Treatment FROM WOOD_MATERIAL", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //SPØRG LEIF
                        Wood wood = new Wood
                        (
                            reader["Sort"].ToString(),
                            reader["Type"].ToString(),
                            reader["Treatment"].ToString(),
                            Convert.ToDouble(reader["Height"].ToString()),
                            Convert.ToDouble(reader["Length"].ToString()),
                            Convert.ToDouble(reader["Width"].ToString()),
                            int.Parse(reader["Quantity"].ToString())
                        );
                        wood_Materials.Add(wood);
                    }
                }
            }
        }
        public Wood Get(string t)
        {
            return null;
        }

        public List<Wood> GetAll()
        {
            return wood_Materials;
        }
    }
}
    