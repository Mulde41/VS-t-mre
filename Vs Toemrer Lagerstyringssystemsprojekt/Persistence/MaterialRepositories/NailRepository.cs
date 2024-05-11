using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories
{
    public class NailRepository : IRepository<IMaterial>
    {
        private List<Nail> _nail_Materials = new List<Nail>();
        private bool _isInitialized = false;
        private static NailRepository _instance;
        private static readonly object _lock = new object();

        public NailRepository()
        {
            InitializeRepository();
        }

        //Singleton pattern |
        //                  V      
        public static NailRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensure thread safety
                    {
                        if (_instance == null)
                        {
                            _instance = new NailRepository();
                        }
                    }
                }
                return _instance;
            }
        }
        private void InitializeRepository()
        {
            if (!_isInitialized)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("SELECT Length, Form, Quantity, Treatment FROM NAIL", connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Nail nail = new Nail
                                (
                                    Convert.ToDouble(reader["Length"].ToString()),
                                    reader["Form"].ToString(),
                                    int.Parse(reader["Quantity"].ToString()),
                                    reader["Treatment"].ToString()
                                );
                                _nail_Materials.Add(nail);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Error initializing nail repository", ex);
                }
            }
            _isInitialized = true;
        }

        public IEnumerable<IMaterial> Get(string partialName)
        {
            List<Nail> matchingNails = new List<Nail>();

            foreach (var nail in _nail_Materials)
            {
                if (nail.Name.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchingNails.Add(nail);
                }
            }

            return matchingNails;
        }

        public List<Nail> GetAll()
        {
            return _nail_Materials;
        }

    }
}
