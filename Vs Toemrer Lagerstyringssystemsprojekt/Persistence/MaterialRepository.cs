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
    //public class MaterialRepository : IRepository<Material>
    //{
    //    private List<Material> materials = new List<Material>();

    //    public MaterialRepository()
    //    {
    //        InitializeRepository();
    //    }
    //    private void InitializeRepository()
    //    {
    //        using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
    //        {
    //            connection.Open();

    //            SqlCommand command = new SqlCommand("SELECT Sort, Type, Height, Length, Width, Quantity, Treatment FROM WOOD_MATERIAL", connection);
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    //SPØRG LEIF
    //                    Wood wood = new Wood
    //                    (
    //                        reader["Sort"].ToString(),
    //                        reader["Type"].ToString(),
    //                        Convert.ToDouble(reader["Height"].ToString()),
    //                        Convert.ToDouble(reader["Length"].ToString()),
    //                        Convert.ToDouble(reader["Width"].ToString()),
    //                        int.Parse(reader["Quantity"].ToString()),
    //                        reader["Treatment"].ToString()
    //                    );
    //                    materials.Add(wood);
    //                }
    //            }
    //        }
    //    }

    //    public Material Get(Material t)
    //    {
    //        return null;
    //    }

    //    List<Material> IRepository<Material>.GetAll()
    //    {
    //        return null;
    //    }
    //}
}
