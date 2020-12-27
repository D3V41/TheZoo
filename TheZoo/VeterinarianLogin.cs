using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace TheZoo
{
    public partial class VeterinarianLogin : UserControl
    {
        public VeterinarianLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public static string managername;
        public static string role;



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            try
            {
                SqlConnection myconnection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Zoodatabase;Integrated Security=True;Pooling=False");
                SqlCommand mycommand = new SqlCommand("SELECT V_Email,V_Mobile FROM Veterinarians WHERE V_Email = @M_email AND V_Mobile = @M_mobile", myconnection);

                SqlParameter memail = new SqlParameter("@M_email", SqlDbType.VarChar);
                SqlParameter mpassword = new SqlParameter("@M_mobile", SqlDbType.VarChar);

                memail.Value = textBox2.Text.Trim();
                mpassword.Value = textBox1.Text.Trim();

                mycommand.Parameters.Add(memail);
                mycommand.Parameters.Add(mpassword);

                mycommand.Connection.Open();

                SqlDataReader myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection);

                managername = textBox2.Text;
                role = "vet";

                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully ");

                    Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Veterinarians()); });

                    myThread.Start();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Login Failed....... Try Again ! ! ! ", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VeterinarianLogin_Load(object sender, EventArgs e)
        {
            textBox2.Text = "deval@gmail.com";
            textBox1.Text = "9664617729";
        }
    }
}
