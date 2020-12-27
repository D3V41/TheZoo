using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace TheZoo
{
    public partial class ManagerLogin : UserControl
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public static string managername;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand mycommand = new SqlCommand("SELECT M_email,M_dob FROM Managers WHERE M_email = @M_email AND M_mobile = @M_mobile", myconnection);

                SqlParameter memail = new SqlParameter("@M_email", SqlDbType.VarChar);
                SqlParameter mpassword = new SqlParameter("@M_mobile", SqlDbType.VarChar);

                memail.Value = textBox2.Text.Trim();
                mpassword.Value = textBox1.Text.Trim();

                mycommand.Parameters.Add(memail);
                mycommand.Parameters.Add(mpassword);

                mycommand.Connection.Open();

                SqlDataReader myReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection);

                managername = textBox2.Text;

                if(myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully ");
                     
                    Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Manager()); }); 
                                                                                                               
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            textBox2.Text = "deval@gmail.com";
            textBox1.Text = "9664617729";
        }
    }
}
