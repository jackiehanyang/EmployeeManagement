using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using EmployeeManagement.LINQ;
using EmployeeManagementLibrary.Data.Repositories;

namespace EmployeeManagement
{
    /// <summary>
    /// Summary description for EMService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EMService : System.Web.Services.WebService
    {
        IRepository<Employee> repo;

        public EMService()
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

        [WebMethod]
        public void Add()
        {
            repo.Add(new Employee());
        }

    }
}
