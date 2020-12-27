using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheZoo
{
    class Animal
    {
        String newspecies, newanimalname, newgender, newhealth, newstatus,newborn;
        DateTime newdate;
        Image newimage;
        ImageConverter Converter = new ImageConverter();
        


        public Animal()
        {

        }

        public Animal(String newspecies, String newanimalname, String newgender, String newhealth, String newstatus,String newborn, DateTime newdate, Image newimage)
        {
            this.newspecies = newspecies;
            this.newanimalname = newanimalname;
            this.newgender = newgender;
            this.newhealth = newhealth;
            this.newstatus = newstatus;
            this.newborn = newborn;
            this.newdate = newdate;
            this.newimage = newimage;
        }

        public String AddNewAnimal()
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO Animals (A_Name,A_Status,A_Species,A_Gender,A_Dob,A_BornOrArrived,A_Health,A_Image) VALUES(@newanimalname,@newstatus,@newspecies,@newgender,@newdate,@newborn,@newhealth,@newimage)", myconnection);

                mycommand.Parameters.Add("@newanimalname", SqlDbType.VarChar).Value = newanimalname;
                mycommand.Parameters.Add("@newstatus", SqlDbType.VarChar).Value = newstatus;
                mycommand.Parameters.Add("@newspecies", SqlDbType.VarChar).Value = newspecies;
                mycommand.Parameters.Add("@newgender", SqlDbType.VarChar).Value = newgender;
                mycommand.Parameters.Add("@newborn", SqlDbType.VarChar).Value = newborn;
                mycommand.Parameters.Add("@newhealth", SqlDbType.VarChar).Value = newhealth;
                mycommand.Parameters.Add("@newdate", SqlDbType.Date).Value = newdate;
                mycommand.Parameters.Add("@newimage", SqlDbType.Image).Value = (byte[])Converter.ConvertTo(newimage,typeof(byte[]));



                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Added Successfully!!!!";
        }
        public (String[],PictureBox[]) ShowMammals()
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals", myconnection);
                using(SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while(sqlDataReader.Read())
                    {
                        mammals[i++] = "Id :                      "+sqlDataReader["A_Id"].ToString();
                        mammals[i++] = "Name :                "+sqlDataReader["A_Name"].ToString();
                        mammals[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                        mammals[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                        mammals[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                        mammals[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                        mammals[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                        mammals[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                        mammals[i++] = sqlDataReader["A_Image"].ToString();
                        
                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox1[k] = new PictureBox();
                        pictureBox1[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch(Exception ex)
            {
                mammals[0] = ex.Message;
                return  (mammals,pictureBox1);
            }
            mammals[0] = Convert.ToString(i-1);
            return (mammals,pictureBox1);
        }

        public (String[], PictureBox[]) SearchName(String name)
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                if (name=="Mammal" || name=="Reptile" || name=="Bird" || name=="Fish")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Species=@name", myconnection);
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            birds[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                            birds[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                            birds[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                            birds[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                            birds[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                            birds[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                            birds[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                            birds[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                            birds[i++] = sqlDataReader["A_Image"].ToString();

                            byte[] hi = (byte[])sqlDataReader["A_Image"];
                            stream = new MemoryStream(hi);
                            pictureBox2[k] = new PictureBox();
                            pictureBox2[k].Image = Image.FromStream(stream);
                            k++;

                        }
                    }
                }
                else if(Regex.IsMatch(name, @"^\d+$"))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Id=@name", myconnection);
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            birds[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                            birds[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                            birds[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                            birds[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                            birds[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                            birds[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                            birds[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                            birds[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                            birds[i++] = sqlDataReader["A_Image"].ToString();

                            byte[] hi = (byte[])sqlDataReader["A_Image"];
                            stream = new MemoryStream(hi);
                            pictureBox2[k] = new PictureBox();
                            pictureBox2[k].Image = Image.FromStream(stream);
                            k++;

                        }
                    }
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Name=@name", myconnection);
                    command.Parameters.AddWithValue("@name", name);
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            birds[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                            birds[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                            birds[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                            birds[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                            birds[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                            birds[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                            birds[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                            birds[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                            birds[i++] = sqlDataReader["A_Image"].ToString();

                            byte[] hi = (byte[])sqlDataReader["A_Image"];
                            stream = new MemoryStream(hi);
                            pictureBox2[k] = new PictureBox();
                            pictureBox2[k].Image = Image.FromStream(stream);
                            k++;

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                birds[0] = ex.Message;
                return (birds, pictureBox2);
            }
            birds[0] = Convert.ToString(i - 1);
            return (birds, pictureBox2);
        }
        public (String[], PictureBox[]) ShowBirds()
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Species=@species", myconnection);
                command.Parameters.AddWithValue("@species", "Bird");
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        birds[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                        birds[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                        birds[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                        birds[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                        birds[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                        birds[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                        birds[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                        birds[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                        birds[i++] = sqlDataReader["A_Image"].ToString();

                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox2[k] = new PictureBox();
                        pictureBox2[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch (Exception ex)
            {
                birds[0] = ex.Message;
                return (birds, pictureBox2);
            }
            birds[0] = Convert.ToString(i - 1);
            return (birds, pictureBox2);
        }
        public (String[], PictureBox[]) ShowReptiles()
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Species=@species", myconnection);
                command.Parameters.AddWithValue("@species", "Reptile");
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        reptiles[i++] = "Id :                        " + sqlDataReader["A_Id"].ToString();
                        reptiles[i++] = "Name :                   " + sqlDataReader["A_Name"].ToString();
                        reptiles[i++] = "Status :                   " + sqlDataReader["A_Status"].ToString();
                        reptiles[i++] = "Species :               " + sqlDataReader["A_Species"].ToString();
                        reptiles[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                        reptiles[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                        reptiles[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                        reptiles[i++] = "Health :                   " + sqlDataReader["A_Health"].ToString();
                        reptiles[i++] = sqlDataReader["A_Image"].ToString();

                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox3[k] = new PictureBox();
                        pictureBox3[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch (Exception ex)
            {
                reptiles[0] = ex.Message;
                return (reptiles, pictureBox3);
            }
            reptiles[0] = Convert.ToString(i - 1);
            return (reptiles, pictureBox3);
        }
        public (String[], PictureBox[]) ShowFishes()
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Species=@species", myconnection);
                command.Parameters.AddWithValue("@species", "Fish");
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        fishes[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                        fishes[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                        fishes[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                        fishes[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                        fishes[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                        fishes[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                        fishes[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                        fishes[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                        fishes[i++] = sqlDataReader["A_Image"].ToString();

                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox4[k] = new PictureBox();
                        pictureBox4[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch (Exception ex)
            {
                fishes[0] = ex.Message;
                return (fishes, pictureBox4);
            }
            fishes[0] = Convert.ToString(i - 1);
            return (fishes, pictureBox4);
        }
        public (String[], PictureBox[]) ShowMammalss()
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Species=@species", myconnection);
                command.Parameters.AddWithValue("@species", "Mammal");
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        fishes[i++] = "Id :                      " + sqlDataReader["A_Id"].ToString();
                        fishes[i++] = "Name :                " + sqlDataReader["A_Name"].ToString();
                        fishes[i++] = "Status :               " + sqlDataReader["A_Status"].ToString();
                        fishes[i++] = "Species :             " + sqlDataReader["A_Species"].ToString();
                        fishes[i++] = "Gender :              " + sqlDataReader["A_Gender"].ToString();
                        fishes[i++] = "Date of Birth :      " + sqlDataReader["A_Dob"].ToString();
                        fishes[i++] = "Born or Arrived :   " + sqlDataReader["A_BornOrArrived"].ToString();
                        fishes[i++] = "Health :                " + sqlDataReader["A_Health"].ToString();
                        fishes[i++] = sqlDataReader["A_Image"].ToString();

                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox4[k] = new PictureBox();
                        pictureBox4[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch (Exception ex)
            {
                fishes[0] = ex.Message;
                return (fishes, pictureBox4);
            }
            fishes[0] = Convert.ToString(i - 1);
            return (fishes, pictureBox4);
        }

        public (String[], PictureBox[]) EditAnimal(String id)
        {
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            MemoryStream stream;
            PictureBox[] pictureBox1 = new PictureBox[50];
            PictureBox[] pictureBox2 = new PictureBox[50];
            PictureBox[] pictureBox3 = new PictureBox[50];
            PictureBox[] pictureBox4 = new PictureBox[50];

            int i = 1;
            int k = 1;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE A_Id=@id", myconnection);
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        mammals[i++] = sqlDataReader["A_Id"].ToString();
                        mammals[i++] = sqlDataReader["A_Name"].ToString();
                        mammals[i++] =  sqlDataReader["A_Status"].ToString();
                        mammals[i++] =  sqlDataReader["A_Species"].ToString();
                        mammals[i++] =  sqlDataReader["A_Gender"].ToString();
                        mammals[i++] = sqlDataReader["A_Dob"].ToString();
                        mammals[i++] =  sqlDataReader["A_BornOrArrived"].ToString();
                        mammals[i++] =  sqlDataReader["A_Health"].ToString();
                        mammals[i++] = sqlDataReader["A_Image"].ToString();

                        byte[] hi = (byte[])sqlDataReader["A_Image"];
                        stream = new MemoryStream(hi);
                        pictureBox1[k] = new PictureBox();
                        pictureBox1[k].Image = Image.FromStream(stream);
                        k++;

                    }
                }
            }
            catch (Exception ex)
            {
                mammals[0] = ex.Message;
                return (mammals, pictureBox1);
            }
            mammals[0] = Convert.ToString(i - 1);
            return (mammals, pictureBox1);
        }

        public String UpdateAnimal(String id)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("UPDATE Animals SET A_Name=@newanimalname ,A_Status=@newstatus ,A_Species=@newspecies ,A_Gender=@newgender ,A_Dob=@newdate ,A_BornOrArrived=@newborn ,A_Health=@newhealth ,A_Image=@newimage Where A_Id=@id", myconnection);
                mycommand.Parameters.AddWithValue("@id", id);

                mycommand.Parameters.Add("@newanimalname", SqlDbType.VarChar).Value = newanimalname;
                mycommand.Parameters.Add("@newstatus", SqlDbType.VarChar).Value = newstatus;
                mycommand.Parameters.Add("@newspecies", SqlDbType.VarChar).Value = newspecies;
                mycommand.Parameters.Add("@newgender", SqlDbType.VarChar).Value = newgender;
                mycommand.Parameters.Add("@newborn", SqlDbType.VarChar).Value = newborn;
                mycommand.Parameters.Add("@newhealth", SqlDbType.VarChar).Value = newhealth;
                mycommand.Parameters.Add("@newdate", SqlDbType.Date).Value = newdate;
                mycommand.Parameters.Add("@newimage", SqlDbType.Image).Value = (byte[])Converter.ConvertTo(newimage, typeof(byte[]));



                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Updated Successfully!!!!";
        }

        public String DeleteAnimal(String id)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("DELETE FROM Animals Where A_Id=@id", myconnection);
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


