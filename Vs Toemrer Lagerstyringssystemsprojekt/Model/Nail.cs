using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Nail : IMaterial
    {
        public double Length { get; set; }
        public string Form { get; set; }
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get => $"{Form} {Length}mm {Treatment}"; }

        public Nail(double Length, string Form, int Quantity, string Treatment)
        {
            this.Length = Length;
            this.Form = Form;
            this.Quantity = Quantity;
            this.Treatment = Treatment;
        }
    }
}
