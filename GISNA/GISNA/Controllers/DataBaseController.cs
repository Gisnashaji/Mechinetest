using GISNA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GISNA.Controllers
{
    public class DataBaseController : Controller
    {
        public IActionResult Index()
        {
            SqlConnection connectionObject = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Gisna;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            connectionObject.Open();
            //string createTableQuery = "CREATE TABLE employees(empolyee_id INT PRIMARY KEY IDENTITY(1,1),empolyee_name VARCHAR (40))";
            //string insertQuery = "INSERT INTO employees(empolyee_name)VALUES(@name)";
            //List<Employee> employee_details = new List<Employee>();
            //string sql = "SELECT employee_id,employee_name FROM employees";
            //string updateQuery = "UPDATE employees SET employee_name=@empName WHERE employee_id=@id";
            string deleteQuery = "DELETE FROM employees WHERE employee_id=@id";
            using (SqlCommand commandObject=new SqlCommand(deleteQuery, connectionObject))
            {
                //commandObject.Parameters.AddWithValue("@name", "Gisna Shaji");
                //commandObject.ExecuteNonQuery();
                //commandObject.Parameters.AddWithValue("@id", 1);
                //commandObject.Parameters.AddWithValue("@empName", "Salna Sabu");
                //var queryResult= commandObject.ExecuteNonQuery();
                //ViewBag.Result="Number of rows affected" + queryResult;
                commandObject.Parameters.AddWithValue("@id", 2);
                var queryResult = commandObject.ExecuteNonQuery();
                ViewBag.Result = "Number of rows affected" + queryResult;
                //using (SqlDataReader reader = commandObject.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        employee_details.Add(new Employee() { EmployeeId=reader.GetInt32(0), EmployeeName=reader.GetString(1) });
                //    }
                //}
            }
            return View();
        }
    }
}
