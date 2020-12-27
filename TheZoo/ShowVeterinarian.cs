using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheZoo
{
    public partial class ShowVeterinarian : UserControl
    {
        public ShowVeterinarian()
        {
            Veterinarian veterinarian = new Veterinarian();
            String[] mammals = new String[500];

            int i, size = 100;
            int k = 1;
            int left = 25;
            InitializeComponent();

            searchvet.Visible = false;
            showvet.AutoScroll = true;
            searchvet.AutoScroll = false;
            btnBack2.Visible = false;
            txtsearchbar.Text = "Search...";




            showvet.Visible = true;


            mammals = veterinarian.ShowVeterinarian();


            size = Convert.ToInt32(mammals[0]) / 6;



            for (i = 0; i < size; i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                Label lbldob = new Label();
                /* Label lblbornorarrived = new Label();
                 Label lblhealth = new Label();*/

                lblid.Text = mammals[k++];
                lblname.Text = mammals[k++];
                lblstatus.Text = mammals[k++];
                lblspecies.Text = mammals[k++];
                lblgender.Text = mammals[k++];
                lbldob.Text = mammals[k++];
                /*lblbornorarrived.Text = mammals[k++];
                lblhealth.Text = mammals[k++];*/


                showvet.Controls.Add(lblid);
                showvet.Controls.Add(lblname);
                showvet.Controls.Add(lblstatus);
                showvet.Controls.Add(lblspecies);
                showvet.Controls.Add(lblgender);
                showvet.Controls.Add(lbldob);
                /* showmammal.Controls.Add(lblbornorarrived);
                 showmammal.Controls.Add(lblhealth);
                 showmammal.Controls.Add(picanimal1[i + 1]);*/

                lblid.Top = left; lblid.Left = 10; lblid.Width = 200; lblid.Font = new Font("Arial", 10, FontStyle.Regular);
                /*                picanimal1[i + 1].Top = left; picanimal1[i + 1].Left = 500;*/
                left = left + 25;
                lblname.Top = left; lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 75;
                /* lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                 lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                 picanimal1[i + 1].Height = 200;
                 picanimal1[i + 1].Width = 150;
                 picanimal1[i + 1].SizeMode = PictureBoxSizeMode.Zoom;*/


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchvet.Visible = true;
            searchvet.AutoScroll = true;
            btnBack2.Visible = true;
            btnback.Visible = false;
            Caretaker caretaker = new Caretaker();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];

            int i, size = 100;
            int k = 1;
            int left = 25;
            searchvet.Controls.Clear();
            showvet.AutoScroll = false;
            String searchname = txtsearchbar.Text;
            birds = caretaker.SearchName(searchname);
            size = Convert.ToInt32(birds[0]) / 6;



            for (i = 0; i < size; i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                Label lbldob = new Label();
                /* Label lblbornorarrived = new Label();
                 Label lblhealth = new Label();*/

                lblid.Text = birds[k++];
                lblname.Text = birds[k++];
                lblstatus.Text = birds[k++];
                lblspecies.Text = birds[k++];
                lblgender.Text = birds[k++];
                lbldob.Text = birds[k++];
                /*lblbornorarrived.Text = mammals[k++];
                lblhealth.Text = mammals[k++];*/


                searchvet.Controls.Add(lblid);
                searchvet.Controls.Add(lblname);
                searchvet.Controls.Add(lblstatus);
                searchvet.Controls.Add(lblspecies);
                searchvet.Controls.Add(lblgender);
                searchvet.Controls.Add(lbldob);
                /* showmammal.Controls.Add(lblbornorarrived);
                 showmammal.Controls.Add(lblhealth);
                 showmammal.Controls.Add(picanimal1[i + 1]);*/

                lblid.Top = left; lblid.Left = 10; lblid.Width = 200; lblid.Font = new Font("Arial", 10, FontStyle.Regular);
                /*                picanimal1[i + 1].Top = left; picanimal1[i + 1].Left = 500;*/
                left = left + 25;
                lblname.Top = left; lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 75;
                /* lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                 lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                 picanimal1[i + 1].Height = 200;
                 picanimal1[i + 1].Width = 150;
                 picanimal1[i + 1].SizeMode = PictureBoxSizeMode.Zoom;*/

            }
        }

            private void btnBack2_Click(object sender, EventArgs e)
        {
            searchvet.Visible = false;
            showvet.AutoScroll = true;
            btnBack2.Visible = false;
            btnback.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
