﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheZoo
{
    class Veterinarian
    {

        String name, gender, mobile, email;
        DateTime date;

        public Veterinarian()
        {

        }

        public Veterinarian(String name, String gender, String mobile, String email, DateTime date)
        {
            this.name = name;
            this.gender = gender;
            this.mobile = mobile;
            this.email = email;
            this.date = date;
        }

        public String[] Veterinarianprofile()
        {
            String[] mammals = new String[500];



            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Veterinarians WHERE V_Email = @email", myconnection);
                command.Parameters.AddWithValue("@email", VeterinarianLogin.managername);

                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        mammals[i++] = "Id :   " + sqlDataReader["V_Id"].ToString();
                        mammals[i++] = "Name :   " + sqlDataReader["V_Name"].ToString();
                        mammals[i++] = "Date of Birth :   " + sqlDataReader["V_Dob"].ToString();
                        mammals[i++] = "Mobile :   " + sqlDataReader["V_Mobile"].ToString();
                        mammals[i++] = "Email :   " + sqlDataReader["V_Email"].ToString();
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

        public String AddVeterinarian()
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO Veterinarians (V_Name,V_Gender,V_Dob,V_Email,V_Mobile) VALUES(@name,@gender,@date,@email,@mobile)", myconnection);

                mycommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                mycommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                mycommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                mycommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = mobile;
                mycommand.Parameters.Add("@date", SqlDbType.Date).Value = date;



                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Added Successfully!!!!";
        }

        public String[] ShowVeterinarian()
        {
            String[] mammals = new String[500];



            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Veterinarians", myconnection);
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        mammals[i++] = "Id :   " + sqlDataReader["V_Id"].ToString();
                        mammals[i++] = "Name :   " + sqlDataReader["V_Name"].ToString();
                        mammals[i++] = "Gender :   " + sqlDataReader["V_Gender"].ToString();
                        mammals[i++] = "Date of Birth :   " + sqlDataReader["V_Dob"].ToString();
                        mammals[i++] = "Mobile :   " + sqlDataReader["V_Mobile"].ToString();
                        mammals[i++] = "Email :   " + sqlDataReader["V_Email"].ToString();
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

        public String[] SearchName(String name)
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];



            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();

                if (Regex.IsMatch(name, @"^\d+$"))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Veterinarians WHERE V_Id=@name", myconnection);
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            birds[i++] = "Id :   " + sqlDataReader["V_Id"].ToString();
                            birds[i++] = "Name :   " + sqlDataReader["V_Name"].ToString();
                            birds[i++] = "Gender :   " + sqlDataReader["V_Gender"].ToString();
                            birds[i++] = "Date of Birth :   " + sqlDataReader["V_Dob"].ToString();
                            birds[i++] = "Mobile :   " + sqlDataReader["V_Mobile"].ToString();
                            birds[i++] = "Email :   " + sqlDataReader["V_Email"].ToString();



                        }
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Veterinarians WHERE V_Name=@name", myconnection);
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            birds[i++] = "Id :   " + sqlDataReader["V_Id"].ToString();
                            birds[i++] = "Name :   " + sqlDataReader["V_Name"].ToString();
                            birds[i++] = "Gender :   " + sqlDataReader["V_Gender"].ToString();
                            birds[i++] = "Date of Birth :   " + sqlDataReader["V_Dob"].ToString();
                            birds[i++] = "Mobile :   " + sqlDataReader["V_Mobile"].ToString();
                            birds[i++] = "Email :   " + sqlDataReader["V_Email"].ToString();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                birds[0] = ex.Message;
                return (birds);
            }
            birds[0] = Convert.ToString(i - 1);
            return (birds);
        }

        public String[] EditVeterinarian(String id)
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];


            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Veterinarians WHERE V_Id=@id", myconnection);
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        mammals[i++] = sqlDataReader["V_Id"].ToString();
                        mammals[i++] = sqlDataReader["V_Name"].ToString();
                        mammals[i++] = sqlDataReader["V_Gender"].ToString();
                        mammals[i++] = sqlDataReader["V_Dob"].ToString();
                        mammals[i++] = sqlDataReader["V_Mobile"].ToString();
                        mammals[i++] = sqlDataReader["V_Email"].ToString();


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

        public String UpdateVeterinarian(String id)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("UPDATE Veterinarians SET V_Name=@name ,V_Gender=@gender ,V_Email=@email ,V_Mobile=@mobile ,V_Dob=@date Where V_Id=@id", myconnection);
                mycommand.Parameters.AddWithValue("@id", id);

                mycommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                mycommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                mycommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                mycommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = mobile;
                mycommand.Parameters.Add("@date", SqlDbType.Date).Value = date;



                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Updated Successfully!!!!";
        }

        public String DeleteVeterinarian(String id)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("DELETE FROM Veterinarians Where V_Id=@id", myconnection);
                mycommand.Parameters.AddWithValue("@id", id);

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Deleted Successfully!!!!";
        }



    }
}
