using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.DataAccess.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> FindAll();
        T Find(int id);
        T Modify(T Entity);
        T Save(T Entity);
        bool Delete(int id);
    }

}
