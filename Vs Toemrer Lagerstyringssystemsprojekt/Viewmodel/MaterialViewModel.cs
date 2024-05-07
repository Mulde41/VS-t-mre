using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public abstract class MaterialViewModel : INotifyPropertyChanged
    {
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public abstract string Name { get; }

        protected MaterialViewModel(int quantity, string treatment)
        {
            this.Treatment = treatment;
            this.Quantity = quantity;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
