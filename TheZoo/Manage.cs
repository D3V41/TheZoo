using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    class Manage
    {

        public String[] Managerprofile()
        {
            String[] mammals = new String[500];



            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Managers WHERE M_email = @email", myconnection);
                command.Parameters.AddWithValue("@email", ManagerLogin.managername);

                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        mammals[i++] = "Id :   " + sqlDataReader["M_Id"].ToString();
                        mammals[i++] = "Name :   " + sqlDataReader["M_Name"].ToString();
                        mammals[i++] = "Date of Birth :   " + sqlDataReader["M_dob"].ToString();
                        mammals[i++] = "Mobile :   " + sqlDataReader["M_mobile"].ToString();
                        mammals[i++] = "Email :   " + sqlDataReader["M_email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                mammals[0] = ex.Message;
                return (mammals);
            }
            mammals[0] = Convert.ToString(i - 1);
            return (mammals);
        }
    }
}
