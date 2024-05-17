using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DataBase.Controllers
{
    public class DBController : Controller
    {
        public IActionResult Index()
        {
            string connectionObject="Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\" DatabaseDB\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //string createTableQuery = "CREATE TABLE customers(customer_id INT PRIMARY KEY IDENTITY(10,2),customer_name VARCHAR(30))";
            //using (SqlCommand commandObject=new SqlCommand(createTableQuery, connectionObject))
            //{
            //    commandObject.ExecuteNonQuery();
            //}
            //string insertQuery = "INSERT INTO customers (customer_name)VALUES(@name)";
            //string updateQuery = "UPDATE customers SET customer_name=@custName WHERE customer_id=@id";
            string deleteQuery = "DELETE FROM customers WHERE customer_id=@id";
            using(SqlConnection connection=new SqlConnection(connectionObject))
            {
                connection.Open();
                using (SqlCommand cmd=new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", 16);
                    var queryResult=cmd.ExecuteNonQuery();
                    ViewBag.Result = "Number of rows affected" + queryResult;
                }
            }
            return View();
        }
    }
}
