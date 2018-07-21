using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Management.Data.Repositories
{
    class DBHelper
    {
        public string GetConnectionString()
        {
            return @"Data Source=TESTPOOL\LEARNSQL;Initial Catalog=Training;Integrated Security=True";
        }
    }
}
