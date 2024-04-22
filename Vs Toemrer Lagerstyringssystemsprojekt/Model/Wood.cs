using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Wood : Material
    {
        public string Sort { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public Wood(string sort, string type, double height, double length, double width) : base()
        {
            this.Sort = sort;
            this.Type = type;
            this.Height = height;
            this.Length = length;
            this.Width = width;
            this.Quantity = base.Quantity;
            this.Treatment = base.Treatment;
            this.MaterialType = base.MaterialType;

        }
        
    }
}
