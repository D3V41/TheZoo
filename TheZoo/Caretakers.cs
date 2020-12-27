using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class Caretakers : Form
    {

        RichTextBox label = new RichTextBox();

        public Caretakers()
        {
            InitializeComponent();
        }

        private void Caretakers_Load(object sender, EventArgs e)
        {
            btnMhome.BackColor = Color.DarkGreen;



            label3.Text = "Caretaker";
            label2.Text = CaretakerLogin.managername;

            showAnimal1.Visible = true;
            CaretakerProfile.Visible = false;

        }

        private void btnMlogout_Click(object sender, EventArgs e)
        {
            btnMlogout.BackColor = Color.DarkGreen;
            btnMhome.BackColor = Color.FromArgb(72, 107, 0);
            btnMreport.BackColor = Color.FromArgb(72, 107, 0);
            btnMprofile.BackColor = Color.FromArgb(72, 107, 0);

            MessageBox.Show("You have logged out successfully ");

            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Login()); });

            myThread.Start();
            Application.Exit();

        }

        private void btnMhome_Click(object sender, EventArgs e)
        {
            btnMhome.BackColor = Color.DarkGreen;
            btnMlogout.BackColor = Color.FromArgb(72, 107, 0);
            btnMreport.BackColor = Color.FromArgb(72, 107, 0);
            btnMprofile.BackColor = Color.FromArgb(72, 107, 0);

            showAnimal1.Visible = true;
            CaretakerProfile.Visible = false;

        }

        private void btnMreport_Click(object sender, EventArgs e)
        {
            btnMreport.BackColor = Color.DarkGreen;
            btnMhome.BackColor = Color.FromArgb(72, 107, 0);
            btnMlogout.BackColor = Color.FromArgb(72, 107, 0);
            btnMprofile.BackColor = Color.FromArgb(72, 107, 0);

            showAnimal1.Visible = false;
            CaretakerProfile.Visible = true;
            CaretakerReport.Visible = true;

            Report report = new Report();
            String rep = report.ShowCReport();


            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            rep = report.ShowFReport();
            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            rep = report.ShowHReport();
            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            label.Top = 20; label.Font = new Font("Arial", 15, FontStyle.Regular); label.Dock = DockStyle.Fill;
            CaretakerReport.Controls.Add(label);


        }

        private void btnMprofile_Click(object sender, EventArgs e)
        {
            btnMprofile.BackColor = Color.DarkGreen;
            btnMhome.BackColor = Color.FromArgb(72, 107, 0);
            btnMreport.BackColor = Color.FromArgb(72, 107, 0);
            btnMlogout.BackColor = Color.FromArgb(72, 107, 0);

            showAnimal1.Visible = false;
            CaretakerProfile.Visible = true;
            CaretakerReport.Visible = false;

            

            Caretaker caretaker = new Caretaker();
            String[] mammals = new String[500];

            int i, size = 100;
            int k = 1;
            int left = 50;

            Label title = new Label();
            title.Text = "Caretaker Profile";
            CaretakerProfile.Controls.Add(title);
            title.Left = 5; title.Width = 500; title.Font = new Font("Arial", 15, FontStyle.Bold); title.Top = 10;

            mammals = caretaker.Caretakerprofile();


            size = Convert.ToInt32(mammals[0]) / 5;



            for (i = 0; i < size; i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                /*Label lbldob = new Label();
                *//* Label lblbornorarrived = new Label();
                 Label lblhealth = new Label();*/

                lblid.Text = mammals[k++];
                lblname.Text = mammals[k++];
                lblstatus.Text = mammals[k++];
                lblspecies.Text = mammals[k++];
                lblgender.Text = mammals[k++];
                /*lbldob.Text = mammals[k++];
                *//*lblbornorarrived.Text = mammals[k++];
                lblhealth.Text = mammals[k++];*/


                CaretakerProfile.Controls.Add(lblid);
                CaretakerProfile.Controls.Add(lblname);
                CaretakerProfile.Controls.Add(lblstatus);
                CaretakerProfile.Controls.Add(lblspecies);
                CaretakerProfile.Controls.Add(lblgender);
                /*showcaretaker.Controls.Add(lbldob);
                *//* showmammal.Controls.Add(lblbornorarrived);
                 showmammal.Controls.Add(lblhealth);
                 showmammal.Controls.Add(picanimal1[i + 1]);*/

                lblid.Top = left; lblid.Left = 10; lblid.Width = 200; lblid.Font = new Font("Arial", 10, FontStyle.Regular);
                /*                picanimal1[i + 1].Top = left; picanimal1[i + 1].Left = 500;*/
                left = left + 25;
                lblname.Top = left; lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                /* lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 75;
                 *//* lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                  lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                  picanimal1[i + 1].Height = 200;
                  picanimal1[i + 1].Width = 150;
                  picanimal1[i + 1].SizeMode = PictureBoxSizeMode.Zoom;*/

            }
        }
    }
}
