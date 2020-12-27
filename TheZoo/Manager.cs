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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            label2.Text = ManagerLogin.managername;
            btnMhome.BackColor = Color.DarkGreen;
            homepanel.Visible = true;
            addAnimal2.Visible = false;
            managerReport1.Visible = false;
            showAnimal1.Visible = false;
            editAnimal1.Visible = false;
            addCaretaker1.Visible = false;
            showCaretakers1.Visible = false;
            editCaretaker1.Visible = false;
            addVeterinarian1.Visible = false;
            editVeterinarian1.Visible = false;
            showVeterinarian1.Visible = false;
            managerprofile1.Visible = false;


            btnDeleteani.Visible = false;
            btnDeletecar.Visible = false;
            btnDeletevet.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox14.Visible = false;


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
            managerReport1.Visible = false;
            homepanel.Visible = true;
            addAnimal2.Visible = false;
            showAnimal1.Visible = false;
            editAnimal1.Visible = false;
            addCaretaker1.Visible = false;
            showCaretakers1.Visible = false;
            editCaretaker1.Visible = false;
            addVeterinarian1.Visible = false;
            editVeterinarian1.Visible = false;
            showVeterinarian1.Visible = false;
            managerprofile1.Visible = false;

        }

        private void btnMreport_Click(object sender, EventArgs e)
        {
            btnMreport.BackColor = Color.DarkGreen;
            btnMhome.BackColor = Color.FromArgb(72, 107, 0);
            btnMlogout.BackColor = Color.FromArgb(72, 107, 0);
            btnMprofile.BackColor = Color.FromArgb(72, 107, 0);

            managerReport1.Visible = true;
            addAnimal2.Visible = false;
            showAnimal1.Visible = false;
            editAnimal1.Visible = false;
            addCaretaker1.Visible = false;
            showCaretakers1.Visible = false;
            editCaretaker1.Visible = false;
            addVeterinarian1.Visible = false;
            editVeterinarian1.Visible = false;
            showVeterinarian1.Visible = false;
            managerprofile1.Visible = false;

        }

        private void btnMprofile_Click(object sender, EventArgs e)
        {
            btnMprofile.BackColor = Color.DarkGreen;
            btnMhome.BackColor = Color.FromArgb(72, 107, 0);
            btnMreport.BackColor = Color.FromArgb(72, 107, 0);
            btnMlogout.BackColor = Color.FromArgb(72, 107, 0);
            managerReport1.Visible = false;
            addAnimal2.Visible = false;
            showAnimal1.Visible = false;
            editAnimal1.Visible = false;
            addCaretaker1.Visible = false;
            showCaretakers1.Visible = false;
            editCaretaker1.Visible = false;
            addVeterinarian1.Visible = false;
            editVeterinarian1.Visible = false;
            showVeterinarian1.Visible = false;
            managerprofile1.Visible = true;

            Manage caretaker = new Manage();
            String[] mammals = new String[500];

            int i, size = 100;
            int k = 1;
            int left = 50;

            Label title = new Label();
            title.Text = "Manager Profile";
            managerprofile1.Controls.Add(title);
             title.Left = 5; title.Width = 500; title.Font = new Font("Arial", 15, FontStyle.Bold);title.Top = 10;

            mammals = caretaker.Managerprofile();


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


                managerprofile1.Controls.Add(lblid);
                managerprofile1.Controls.Add(lblname);
                managerprofile1.Controls.Add(lblstatus);
                managerprofile1.Controls.Add(lblspecies);
                managerprofile1.Controls.Add(lblgender);
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

        private void btnShowani_Click(object sender, EventArgs e)
        {
            showAnimal1.Visible = true;
        }

        private void btnAddani_Click(object sender, EventArgs e)
        {
            addAnimal2.Visible = true;
        }

        private void btnEditanim_Click(object sender, EventArgs e)
        {
            editAnimal1.Visible = true;
        }

        private void btnDeleteani_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAddvet_Click(object sender, EventArgs e)
        {
            addVeterinarian1.Visible = true;
        }

        private void btnShowvet_Click(object sender, EventArgs e)
        {
            showVeterinarian1.Visible = true;
        }

        private void btnEditvet_Click(object sender, EventArgs e)
        {
            editVeterinarian1.Visible = true;
        }

        private void btnDeletevet_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAddcar_Click(object sender, EventArgs e)
        {
            addCaretaker1.Visible = true;
        }

        private void btnShowcar_Click(object sender, EventArgs e)
        {
            showCaretakers1.Visible = true;
        }

        private void btnEditcar_Click(object sender, EventArgs e)
        {
            editCaretaker1.Visible = true;
        }

        private void btnDeletecar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerprofile1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
