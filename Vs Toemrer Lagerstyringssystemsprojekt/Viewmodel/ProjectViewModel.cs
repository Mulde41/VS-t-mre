using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ProjectViewModel
    {
        public string Title { get; set; }
        public double Offer { get; set; }
        public string Address { get; set; }
        public string ProjectDescription { get; set; }

        public ProjectViewModel(string title, double offer, string address, string projectDescription)
        {
            Title = title;
            Offer = offer;
            Address = address;
            ProjectDescription = projectDescription;
        }

    }
}
