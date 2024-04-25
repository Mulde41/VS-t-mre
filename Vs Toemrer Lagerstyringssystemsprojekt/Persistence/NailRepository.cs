using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class NailRepository : IRepository<Nail>
    {
        private List<Nail> Nail_Materials = new List<Nail>();

        public NailRepository()
        {
            InitializeRepository();
        }


        private void InitializeRepository()
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Length, Form, Quantity, Treatment FROM NAIL_MATERIAL", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //SPØRG LEIF
                        Nail nail = new Nail
                        (
                            Convert.ToDouble(reader["Length"].ToString()),
                            reader["Form"].ToString(),
                            int.Parse(reader["Quantity"].ToString()),
                            reader["Treatment"].ToString()
                        );
                        Nail_Materials.Add(nail);
                    }
                }
            }
        }
        public Nail Get(string t)
        {
            throw new NotImplementedException();
        }

        public List<Nail> GetAll()
        {
            return Nail_Materials;
        }

    }
}
