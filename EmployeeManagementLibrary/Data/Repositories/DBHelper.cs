using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Data.Repositories
{
    class DBHelper
    {
        public string GetConnectionString()
        {
            return @"Data Source=DESKTOP-K98E5UF\MYSQLSERVER;Initial Catalog=Training;Integrated Security=True";
        }
    }
}
