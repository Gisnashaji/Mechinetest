using Microsoft.Data.SqlClient;
namespace Scope_India.Models
{
    public class Registration
    {
        public void CreateReg(RegisterModel reg, string connectionstring)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO Stud_Reg(FirstName, LastName, DateofBirth, Gender,Email, PhoneNumber, Country, State,City, Hobbies, Upload,Password) " +
                               "VALUES(@FirstName, @LastName, @DateofBirth, @Gender,@Email, @PhoneNumber,  @Country, @State, @City, @Hobbies,@Upload, @Password)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", reg.FirstName);
                cmd.Parameters.AddWithValue("@LastName", reg.LastName);
                cmd.Parameters.AddWithValue("@DateofBirth", reg.DateofBirth);
                cmd.Parameters.AddWithValue("@Gender", reg.Gender);
                cmd.Parameters.AddWithValue("@Email", reg.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", reg.PhoneNumber);
                
                cmd.Parameters.AddWithValue("@Country", reg.Country);
                cmd.Parameters.AddWithValue("@State", reg.State);
                cmd.Parameters.AddWithValue("@City", reg.City);

                // Convert the list of selected languages to a comma-separated string and store it
                string HobbiesMULTI = string.Join(",", reg.Hobbies);
                cmd.Parameters.AddWithValue("@Hobbies", HobbiesMULTI);

                cmd.Parameters.AddWithValue("@Upload", reg.Upload);
                cmd.Parameters.AddWithValue("@Password", reg.Password);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
