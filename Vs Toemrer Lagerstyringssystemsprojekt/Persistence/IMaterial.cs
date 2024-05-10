using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public interface IMaterial
    {
        string Treatment { get; }
        int Quantity { get; }
        string Name { get; }
    }
}
