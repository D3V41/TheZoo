using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    class Report
    {
        public String DeleteCReport()
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("DELETE FROM CleaningReport", myconnection);

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Deleted Successfully!!!!";
        }

        public String AddCReport(String report)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO CleaningReport (Creport) VALUES (@report)", myconnection);
                mycommand.Parameters.Add("@report", SqlDbType.VarChar).Value = report;


                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Added Successfully!!!!";
        }

        public String ShowCReport()
        {
            String report=null;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("SELECT * FROM CleaningReport", myconnection);
                using (SqlDataReader sqlDataReader = mycommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        report = sqlDataReader["Creport"].ToString();
                     
                    }
                }

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return report;
        }

        public String DeleteHReport()
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("DELETE FROM HealthReport", myconnection);

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Deleted Successfully!!!!";
        }

        public String AddHReport(String report)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO HealthReport (Hreport) VALUES (@report)", myconnection);
                mycommand.Parameters.Add("@report", SqlDbType.VarChar).Value = report;


                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Added Successfully!!!!";
        }

        public String ShowHReport()
        {
            String report = null;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("SELECT * FROM HealthReport", myconnection);
                using (SqlDataReader sqlDataReader = mycommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        report = sqlDataReader["Hreport"].ToString();

                    }
                }

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return report;
        }

        public String DeleteFReport()
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("DELETE FROM FeedReport", myconnection);

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Deleted Successfully!!!!";
        }

        public String AddFReport(String report)
        {
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO FeedReport (Freport) VALUES (@report)", myconnection);
                mycommand.Parameters.Add("@report", SqlDbType.VarChar).Value = report;


                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Added Successfully!!!!";
        }

        public String ShowFReport()
        {
            String report = null;
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                myconnection.Open();
                SqlCommand mycommand = new SqlCommand("SELECT * FROM FeedReport", myconnection);
                using (SqlDataReader sqlDataReader = mycommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        report = sqlDataReader["Freport"].ToString();

                    }
                }

                mycommand.ExecuteNonQuery();

                myconnection.Close();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return report;
        }
    }
}
