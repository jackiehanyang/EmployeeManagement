using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.LINQ;

namespace EmployeeManagementLibrary.Data.Repositories
{
    public class EmployeeRepoLINQ : IRepository<Employee>
    {
        EmployeeManagementDataContext context;
        public EmployeeRepoLINQ()
        {
            context = new EmployeeManagementDataContext();
        }

        public void Add(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}
