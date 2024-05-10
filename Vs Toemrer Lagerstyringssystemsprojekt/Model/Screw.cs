using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Screw : IMaterial
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get => $"{ScrewHead} {Length}x{Diameter}mm {Treatment}"; }

        public Screw(string ScrewHead, double Length, double Diameter, int Quantity, string Treatment)
        {
            this.ScrewHead = ScrewHead;
            this.Length = Length;
            this.Diameter = Diameter;
            this.Quantity = Quantity;
            this.Treatment = Treatment;
        }
    }
}
