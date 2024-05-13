using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ProjectViewModel 
    {
        public string Title { get; set; }
        public string Offer { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public ProjectViewModel(Project project)
        {
            Title = project.Title;
            Offer = project.Offer;
            Address = project.Address;
            Description = project.Description;
        }
    }
}
