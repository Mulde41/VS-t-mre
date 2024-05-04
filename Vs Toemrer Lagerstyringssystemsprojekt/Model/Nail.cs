using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Nail : Material
    {
        public double Length { get; set; }
        public string Form { get; set; }
        public override string Name { get; set; }
        public Nail(double Length, string Form, int Quantity, string Treatment) : base(Quantity, Treatment)
        {
            this.Length = Length;
            this.Form = Form;
            base.Treatment = Treatment;
            base.Quantity = Quantity;
            Name = $"{Form} {Length}mm {Treatment}";
        }
    }
}
