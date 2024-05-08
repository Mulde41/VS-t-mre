using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    internal class NailViewModel : MaterialViewModel, INotifyPropertyChanged
    {
        public double Length { get; set; }  
        public string Form {  get; set; }   

        public NailViewModel(Nail nail, int Quantity, string Treatment, string Name) : base(Quantity, Treatment, Name)
        {
            Length = nail.Length;
            Form = nail.Form;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
