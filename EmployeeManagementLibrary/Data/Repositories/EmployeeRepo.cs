using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Management.Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Employee.Management.Data.Repositories
{
    public class EmployeeRepo : IRepostory<Employees>
    {
        DBHelper helper;
        public EmployeeRepo()
        {
            helper = new DBHelper();
        }
        public void Add(Employees obj)
        {
            SqlConnection connection = new SqlConnection(helper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                connection.Open();
                cmd.CommandText = "Insert into Employees values (@name)";
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();  // use this method for the DML statements
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                cmd.Dispose();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetAll()
        {
            SqlConnection connection = new SqlConnection(helper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            List<Employees> lstCustomer = new List<Employees>();
            try
            {
                connection.Open();
                cmd.CommandText = "Select Id,Name,City,State from Customer";

                cmd.Connection = connection;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employees c = new Employees();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.FirstName = Convert.ToString(reader["FirstName"]);
                    c.LastName = Convert.ToString(reader["LastName"]);
                    c.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    c.EndDate = Convert.ToDateTime(reader["EndDate"]);
                    c.CompanyName = Convert.ToString(reader["Company Name"]);
                    lstCustomer.Add(c);
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
                connection.Dispose();
                cmd.Dispose();
            }
            return lstCustomer;
        }
    }
}
