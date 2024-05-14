using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public static class RepositoryHelper
    {
        private static IConfigurationRoot _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        public static string? connectionString = _configuration.GetConnectionString("MyDBconnection");
    }
}
