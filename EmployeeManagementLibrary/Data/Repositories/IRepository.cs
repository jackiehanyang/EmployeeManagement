using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Management.Data.Repositories
{
    public interface IRepository<T>
    {
        void Add(T obj);
        void Delete(int Id);
        IEnumerable<T> GetAll();
    }
}
