using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Wood : IMaterial
    {
        public string Sort { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get => $"{Sort} {Type} {Treatment} {Height}x{Length}x{Width}"; }

        public Wood(string Sort, string Type, double Height, double Length, double Width, int Quantity, string Treatment)
        {
            this.Sort = Sort;
            this.Type = Type;
            this.Height = Height;
            this.Length = Length;
            this.Width = Width;
            this.Quantity = Quantity;
            this.Treatment = Treatment;
            
        }
        
    }
}
