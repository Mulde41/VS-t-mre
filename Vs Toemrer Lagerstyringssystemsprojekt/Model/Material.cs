using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public abstract class Material
    {
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        protected Material(int quantity, string treatment)
        {
            this.Treatment = treatment;
            this.Quantity = quantity;
        }
    }
}
