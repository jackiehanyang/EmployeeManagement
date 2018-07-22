using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using EmployeeManagementLibrary.Data.Repositories;
using EmployeeManagement.LINQ;

namespace EmployeeManagement.DataService
{
    /// <summary>
    /// Summary description for EmployeeManagement
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeManagement : System.Web.Services.WebService
    {
        IRepository<Employee> repo;

        public EmployeeManagement()
        {
            repo = new EmployeeRepoLINQ();
        }

        [WebMethod]
        public List<Employee> GetEmployees()
        {
            return repo.GetAll().ToList();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
