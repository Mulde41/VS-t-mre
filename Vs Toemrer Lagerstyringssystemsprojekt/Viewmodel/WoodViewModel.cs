using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class WoodViewModel : IMaterial
    {
        public string Sort {  get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get => $"{Sort} {Type} {Treatment} {Height}x{Length}x{Width}"; }

        public WoodViewModel(Wood wood)
        { 
            this.Sort = wood.Sort;
            this.Type = wood.Type;
            this.Height = wood.Height;
            this.Width = wood.Width;
            this.Length = wood.Length;
            this.Quantity = wood.Quantity;
            this.Treatment = wood.Treatment;
        }
    }
}
