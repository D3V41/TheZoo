using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            managerLogin1.BringToFront();
            caretakerLogin1.BringToFront();
            veterinarianLogin1.BringToFront();
            managerLogin1.Visible = false;
            caretakerLogin1.Visible = false;
            veterinarianLogin1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerLogin1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veterinarianLogin1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caretakerLogin1.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void veterinarianLogin1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
