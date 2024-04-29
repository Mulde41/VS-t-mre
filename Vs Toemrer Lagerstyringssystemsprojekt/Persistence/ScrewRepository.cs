using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class ScrewRepository : IRepository<Screw>
    {
        private List<Screw> Screw_Materials = new List<Screw>();

        public ScrewRepository()
        {
            InitializeRepository();
        }


        private void InitializeRepository()
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT ScrewHead, Length, Diameter, Form, Quantity, Treatment FROM SCREW_MATERIAL", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //SPØRG LEIF
                        Screw screw = new Screw
                        (
                            reader["ScrewHead"].ToString(),
                            Convert.ToDouble(reader["Length"].ToString()),
                            Convert.ToDouble(reader["Diameter"].ToString()),
                            int.Parse(reader["Quantity"].ToString()),
                            reader["Treatment"].ToString()
                            
                        );
                        Screw_Materials.Add(screw);
                    }
                }
            }
        }
        public Screw Get(string t)
        {
            throw new NotImplementedException();
        }

        public List<Screw> GetAll()
        {
            return Screw_Materials;
        }
    }
}
