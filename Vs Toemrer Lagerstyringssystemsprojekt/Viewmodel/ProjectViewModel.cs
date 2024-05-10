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
    public class ProjectViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Offer { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        //public string Status { get; set; }
        /*public List<Material> Materials { get; set; }*/

        public ProjectViewModel(Project project)
        {
            Title = project.Title;
            Offer = project.Offer;
            Address = project.Address;
            Description = project.Description;
            //Status = "Aktiv"
            /*Materials = new List<Material>();*/
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
