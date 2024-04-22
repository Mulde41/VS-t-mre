using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence
{
    public interface IRepository<T>
    {
        public T Get(T t);
        public List<T> GetAll();
    }
}
