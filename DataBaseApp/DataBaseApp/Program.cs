//using Microsoft.Data.SqlClient;
//try
//{

//    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=scopeindia;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
//    con.Open();
//    //SqlCommand cmd = new SqlCommand("create database scopeindia", con);
//    //SqlCommand cmd = new SqlCommand("create table scope(id int primary key,name varchar(30))", con);
//    //var sql= "INSERT INTO scope (id,name) values (01,'gisna')";
//    //SqlCommand cmd = new SqlCommand("INSERT INTO scope(id,name)values(2,'aida'),(3,'varsha'),(4,'salna')", con) ;
//    SqlCommand cmd = new SqlCommand("UPDATE TABLE scope SET   id to s_id WHERE id=s_id)", con);
//    cmd.ExecuteNonQuery();
//    con.Close();
//    Console.WriteLine("create successfully");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



//using Microsoft.Data.SqlClient;
//using System;
//using System.Data.SqlClient;
//class Sql
//{
//    public static void Main()
//    {
//        try
//        {
//            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=scopeindia;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
//            con.Open();
//            //SqlCommand cmd = new SqlCommand("create table employees(id int  primary key,name varchar(20),branch varchar(15))", con);
//            //SqlCommand cmd = new SqlCommand("INSERT INTO employees(id,name,branch)values(001,'gisna','sales'),(002,'aida','production'),(003,'salna','sales')", con);
//            SqlCommand cmd = new SqlCommand("select * from employees", con);
//            var reader = cmd.ExecuteReader();
//            while (reader.Read())
//            {
//                Console.WriteLine(reader.GetInt32(0));
//                Console.WriteLine(reader.GetString(1));
//            }
//            con.Close();
//            Console.WriteLine("Readed successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}