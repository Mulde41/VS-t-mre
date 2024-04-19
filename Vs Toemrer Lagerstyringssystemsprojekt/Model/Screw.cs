using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Screw : Material
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
    }
}
