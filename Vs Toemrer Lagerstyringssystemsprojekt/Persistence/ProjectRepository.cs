using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class ProjectRepository
    {

        private List<Project> projects = new List<Project>();
        private bool _isInitialized = false;
        private static ProjectRepository _instance;
        private static readonly object _lock = new object();




        public ProjectRepository()
        {
            InitializeRepository();
        }

        //Singleton pattern |
        //                  V      
        public static ProjectRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensure thread safety
                    {
                        if (_instance == null)
                        {
                            _instance = new ProjectRepository();
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

                        SqlCommand command = new SqlCommand("SELECT Title, Offer, Address, ProjectDescription FROM PROJECT", connection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Project project = new Project
                                    (
                                       reader["Title"].ToString(),
                                       Convert.ToDouble(reader["Offer"].ToString()),
                                       reader["Address"].ToString(),
                                       reader["ProjectDescription"].ToString()
                                    );
                                projects.Add(project);
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


        public void Add(Project project)
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO PROJECT(Title,Offer, ProjectDescription, Address)" + "VALUES(@Title,@Offer,@ProjectDescription, @Address)", connection);
                command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = project.Title;
                command.Parameters.Add("@Offer", SqlDbType.Float).Value = project.Offer;
                command.Parameters.Add("@ProjectDescription", SqlDbType.NVarChar).Value = project.ProjectDescription;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = project.Address;
                command.ExecuteNonQuery();
                projects.Add(project);
            }
        }

        public List<Project> GetAll()
        {
            return projects;
        }

        public Project Get(string title)
        {
            //Project result = null;
            //foreach (Project pro in projects)
            //{
            //    if (pro.Title == title)
            //       result = pro;
            //}
            //return result;

            return projects.Find(project => project.Title == title);
        }
    }
}