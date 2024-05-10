using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    internal class NailViewModel
    {
        public double Length { get; set; }  
        public string Form {  get; set; }   
        public int Quantity {  get; set; } 
        public string Treatment { get; set; }
        public string Name { get; set; }

        public NailViewModel(Nail nail)
        {
            this.Length = nail.Length;
            this.Form = nail.Form;
            this.Quantity = nail.Quantity;
            this.Treatment = nail.Treatment;
        }
    }
}
