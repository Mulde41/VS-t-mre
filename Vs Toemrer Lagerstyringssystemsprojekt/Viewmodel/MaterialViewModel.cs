using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class MaterialViewModel : INotifyPropertyChanged 
    {
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get; set; }

        public MaterialViewModel(Material material) 
        {
            Quantity = material.Quantity;
            Treatment = material.Treatment;
            Name = material.Name;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
