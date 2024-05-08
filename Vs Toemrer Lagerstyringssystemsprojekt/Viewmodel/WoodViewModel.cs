using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class WoodViewModel : MaterialViewModel, INotifyPropertyChanged
    {
        public string Sort {  get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public WoodViewModel(Wood wood, int Quantity, string Name, string Treatment) : base (Quantity, Name, Treatment)
        { 
            Sort = wood.Sort;
            Type = wood.Type;
            Height = wood.Height;
            Width = wood.Width;
            Length = wood.Length;
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
