﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories
{
    public class ScrewRepository : IRepository<Screw>
    {
        private List<Screw> _screw_Materials = new List<Screw>();
        private bool _isInitialized = false;
        private static ScrewRepository _instance;
        private static readonly object _lock = new object();
        public ScrewRepository()
        {
            InitializeRepository();
        }

        //Singleton pattern |
        //                  V      
        public static ScrewRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensure thread safety
                    {
                        if (_instance == null)
                        {
                            _instance = new ScrewRepository();
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
                        SqlCommand command = new SqlCommand("SELECT ScrewHead, Length, Diameter, Form, Quantity, Treatment FROM SCREW_MATERIAL", connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Screw screw = new Screw
                                (
                                    reader["ScrewHead"].ToString(),
                                    Convert.ToDouble(reader["Length"].ToString()),
                                    Convert.ToDouble(reader["Diameter"].ToString()),
                                    int.Parse(reader["Quantity"].ToString()),
                                    reader["Treatment"].ToString()
                                );
                                _screw_Materials.Add(screw);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("Error initializing screw repository", ex);
                }
            }
            _isInitialized = true; // Ensures initialization happens only once
        }

        public IEnumerable<Screw> Get(string Identifier)
        {
            throw new NotImplementedException();
        }

        public List<Screw> GetAll()
        {
            return _screw_Materials;
        }

    }
}