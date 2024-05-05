using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Project
    {
        public string Title { get; set; }
        public double Offer { get; set; }
        public string Address { get; set; }
        public string ProjectDescription { get; set; }
        //public string Status { get; set; }
        /*public List<Material> Materials { get; set; }*/

        public Project (string title, double offer, string address, string projectDescription/*string status, List<Material> materials*/)
        {
            Title = title;
            Offer = offer;
            Address = address;
            ProjectDescription = projectDescription;
            //Status = "Aktiv"
            /*Materials = new List<Material>();*/
        }
    }
}
