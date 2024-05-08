using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    internal class LocationViewModel : INotifyPropertyChanged
    {
        public string Position { get; set; }


        public LocationViewModel(Location location) 
        {
            Position = location.Position;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
