using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Wood : Material
    {
        public string Sort { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public override string Name { set { } get { return $"{Sort} {Type} {Treatment} {Height}x{Length}x{Width}"; } }

        public Wood(string Sort, string Type, string Treatment, double Height, double Length, double Width, int Quantity) : base(Quantity, Treatment)
        {
            this.Sort = Sort;
            this.Type = Type;
            this.Height = Height;
            this.Length = Length;
            this.Width = Width;
            Name = $"{Sort} {Type} {Treatment} {Height}x{Length}x{Width}";
        }
        
    }
}
