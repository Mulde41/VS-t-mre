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

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public class ProjectRepository
    {

        

        private List<Project> projects = new List<Project>();

        public ProjectRepository() 
        {
            InitializeRepository();
        }

        private void InitializeRepository() 
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Title, Offer, ProjectDescription, Address FROM PROJECT", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Project project = new Project
                            (
                               reader["Title"].ToString(),
                               Convert.ToDouble(reader["Offer"].ToString()),
                               reader["ProjectDescription"].ToString(),
                               reader["Address"].ToString()
                            );
                        projects.Add(project);
                    }
                }
            }
        }

        public void Add(Project project)
        {
            using (SqlConnection connection = new SqlConnection(RepositoryHelper.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO PROJECT(Title,Offer, ProjectDescription, Address)" + "VALUES(@Title,@Offer,@ProjectDescription, @Address)", connection);
                command.Parameters.Add("@Title",SqlDbType.NVarChar).Value = project.Title;
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

    }
}
