using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Screw : Material
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public override string Name { get => $"{ScrewHead} {Length}x{Diameter}mm {Treatment}"; }

        public Screw(string ScrewHead, double Length, double Diameter, int Quantity, string Treatment) : base(Quantity, Treatment)
        {
            this.ScrewHead = ScrewHead;
            this.Length = Length;
            this.Diameter = Diameter;
            //do not include base class attributes here. they are already included in the constructor
            //do not define Name here it is already defined in the properties
        }
    }
}
