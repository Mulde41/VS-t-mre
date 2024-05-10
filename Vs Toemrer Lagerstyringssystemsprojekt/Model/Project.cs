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
        public string Offer { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Project (string title, string offer, string address, string description)
        {
            Title = title;
            Offer = offer;
            Address = address;
            Description = description;
        }
    }
}
