using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories
{
    public class WoodRepository : IRepository<Wood>
    {
        public List<Wood> _wood_Materials = new List<Wood>();
        private bool _isInitialized = false;
        private static WoodRepository _instance;
        private static readonly object _lock = new object();
        public WoodRepository()
        {
            InitializeRepository();
        }
        public static WoodRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensure thread safety
                    {
                        if (_instance == null)
                        {
                            _instance = new WoodRepository();
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
                        SqlCommand command = new SqlCommand("SELECT Sort, Type, Height, Length, Width, Quantity, Treatment FROM WOOD_MATERIAL", connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
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
                                _wood_Materials.Add(wood);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Error initializing wood repository", ex);
                }
            }
            _isInitialized = true; // Ensures initialization happens only once
        }

        public List<Wood> GetAll()
        {
            return _wood_Materials;
        }

        public IEnumerable<Wood> Get(string partialName)
        {
            // This list will hold all the wood items that contain the partialName in their Name property.
            List<Wood> matchingWoods = new List<Wood>();

            // Use the Contains method to check if the Name property of each wood includes the partialName.
            foreach (Wood wood in _wood_Materials)
            {
                if (wood.Name.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchingWoods.Add(wood);
                }
            }

            // Return the list of matching woods
            return matchingWoods;
        }
    }
}
