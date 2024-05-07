using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ScrewViewModel : MaterialViewModel,INotifyPropertyChanged
    {
        public string ScrewHead {  get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
       


        public ScrewViewModel(Screw screw): base()
        {
            ScrewHead = screw.ScrewHead;
            Length = screw.Length;
            Diameter = screw.Diameter;
            Quantity = screw.Quantity;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
