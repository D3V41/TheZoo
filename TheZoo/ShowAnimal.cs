using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheZoo
{
    public partial class ShowAnimal : UserControl
    {
        
        
        String searchname;

        


        private void btnback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void btnmammal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            int i, size = 100;
            int k = 1;
            int left = 25;
            btnmammal.BackColor = Color.LightGray;
            btnfish.BackColor = SystemColors.Control;
            btnreptile.BackColor = SystemColors.Control;
            btnbird.BackColor = SystemColors.Control;
            showmammal.Visible = true;
            showreptile.Visible = false;
            showbird.Visible = false;
            showfish.Visible = false;

            showmammal.Visible = true;


            (mammals, picanimal1) = animal.ShowMammalss();


            size = Convert.ToInt32(mammals[0]) / 9;

            // MessageBox.Show(size.ToString());


            for (i = 0; i < size; i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                Label lbldob = new Label();
                Label lblbornorarrived = new Label();
                Label lblhealth = new Label();

                lblid.Text = mammals[k++];
                lblname.Text = mammals[k++];
                lblstatus.Text = mammals[k++];
                lblspecies.Text = mammals[k++];
                lblgender.Text = mammals[k++];
                lbldob.Text = mammals[k++];
                lblbornorarrived.Text = mammals[k++];
                lblhealth.Text = mammals[k++];
                k++;


                showmammal.Controls.Add(lblid);
                showmammal.Controls.Add(lblname);
                showmammal.Controls.Add(lblstatus);
                showmammal.Controls.Add(lblspecies);
                showmammal.Controls.Add(lblgender);
                showmammal.Controls.Add(lbldob);
                showmammal.Controls.Add(lblbornorarrived);
                showmammal.Controls.Add(lblhealth);
                showmammal.Controls.Add(picanimal1[i + 1]);

                lblid.Top = left; lblid.Left = 10; lblid.Width = 200; lblid.Font = new Font("Arial", 10, FontStyle.Regular);
                picanimal1[i + 1].Top = left; picanimal1[i + 1].Left = 500;
                left = left + 25;
                lblname.Top = left; lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                picanimal1[i + 1].Height = 200;
                picanimal1[i + 1].Width = 150;
                picanimal1[i + 1].SizeMode = PictureBoxSizeMode.Zoom;



            }

        }
    

        private void btnbird_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            btnmammal.BackColor = SystemColors.Control;
            btnfish.BackColor = SystemColors.Control;
            btnreptile.BackColor = SystemColors.Control;
            btnbird.BackColor = Color.LightGray;
            /*showmammal.Visible = false;
            showreptile.Visible = false;
            showbird.Visible = true;
            showfish.Visible = false;*/
        }

        private void btnreptile_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            btnmammal.BackColor = SystemColors.Control;
            btnfish.BackColor = SystemColors.Control;
            btnreptile.BackColor = Color.LightGray;
            btnbird.BackColor = SystemColors.Control;
            /*showmammal.Visible = false;
            showreptile.Visible = true;
            showbird.Visible = false;
            showfish.Visible = false;*/
        }

        private void btnfish_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            btnmammal.BackColor = SystemColors.Control;
            btnfish.BackColor = Color.LightGray;
            btnreptile.BackColor = SystemColors.Control;
            btnbird.BackColor = SystemColors.Control;
            /*showmammal.Visible = false;
            showreptile.Visible = false;
            showbird.Visible = false;
            showfish.Visible = true;*/
        }

        private void showmammal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchbar_Click(object sender, EventArgs e)
        {
            txtsearchbar.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            int i, size = 100;
            int k = 1;
            int left = 25;
            searchAnimals2.Controls.Clear();
            btnBack2.Visible = true;
            btnback.Visible = false;
            showmammal.AutoScroll = false;
            searchname = txtsearchbar.Text;
            searchAnimals2.Visible = true;
            (birds,picanimal2)=animal.SearchName(searchname);
            size = Convert.ToInt32(birds[0]) / 9;

            //MessageBox.Show(size.ToString());


            for (i = 0; i < size; i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                Label lbldob = new Label();
                Label lblbornorarrived = new Label();
                Label lblhealth = new Label();

                lblid.Text = birds[k++];
                lblname.Text = birds[k++];
                lblstatus.Text = birds[k++];
                lblspecies.Text = birds[k++];
                lblgender.Text = birds[k++];
                lbldob.Text = birds[k++];
                lblbornorarrived.Text = birds[k++];
                lblhealth.Text = birds[k++];
                k++;


                searchAnimals2.Controls.Add(lblid);
                searchAnimals2.Controls.Add(lblname);
                searchAnimals2.Controls.Add(lblstatus);
                searchAnimals2.Controls.Add(lblspecies);
                searchAnimals2.Controls.Add(lblgender);
                searchAnimals2.Controls.Add(lbldob);
                searchAnimals2.Controls.Add(lblbornorarrived);
                searchAnimals2.Controls.Add(lblhealth);
                searchAnimals2.Controls.Add(picanimal2[i + 1]);

                lblid.Top = left; lblid.Left = 10; lblid.Width = 200; lblid.Font = new Font("Arial", 10, FontStyle.Regular);
                picanimal2[i + 1].Top = left; picanimal2[i + 1].Left = 500;
                left = left + 25;
                lblname.Top = left; lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                picanimal2[i + 1].Height = 200;
                picanimal2[i + 1].Width = 150;
                picanimal2[i + 1].SizeMode = PictureBoxSizeMode.Zoom;



            }

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            searchAnimals2.Visible = false;
            btnBack2.Visible = false;
            btnback.Visible = true;
            showmammal.AutoScroll = true;
        }

        public ShowAnimal()
        {
            Animal animal = new Animal();
            String[] mammals = new String[500];
            String[] birds = new String[500];
            String[] reptiles = new String[500];
            String[] fishes = new String[500];
            PictureBox[] picanimal1 = new PictureBox[50];
            PictureBox[] picanimal2 = new PictureBox[50];
            PictureBox[] picanimal3 = new PictureBox[50];
            PictureBox[] picanimal4 = new PictureBox[50];
            int i, size = 100;
            int k = 1;
            int left = 25;
            InitializeComponent();
            btnmammal.BackColor = SystemColors.Control;
            btnfish.BackColor = SystemColors.Control;
            btnreptile.BackColor = SystemColors.Control;
            btnbird.BackColor = SystemColors.Control;
            searchAnimals2.Visible = false;
            btnBack2.Visible = false;
            txtsearchbar.Text = "Search...";

            


            showmammal.Visible = true;
            

            (mammals,picanimal1) = animal.ShowMammals();


            size = Convert.ToInt32(mammals[0])/9;

            // MessageBox.Show(size.ToString());

           
            for(i=0;i<size;i++)
            {
                Label lblid = new Label();
                Label lblname = new Label();
                Label lblstatus = new Label();
                Label lblspecies = new Label();
                Label lblgender = new Label();
                Label lbldob = new Label();
                Label lblbornorarrived = new Label();
                Label lblhealth = new Label();

                lblid.Text = mammals[k++];
                lblname.Text = mammals[k++];
                lblstatus.Text = mammals[k++];
                lblspecies.Text = mammals[k++];
                lblgender.Text = mammals[k++];
                lbldob.Text = mammals[k++];
                lblbornorarrived.Text = mammals[k++];
                lblhealth.Text = mammals[k++];
                k++;


                showmammal.Controls.Add(lblid);
                showmammal.Controls.Add(lblname);
                showmammal.Controls.Add(lblstatus);
                showmammal.Controls.Add(lblspecies);
                showmammal.Controls.Add(lblgender);
                showmammal.Controls.Add(lbldob);
                showmammal.Controls.Add(lblbornorarrived);
                showmammal.Controls.Add(lblhealth);
                showmammal.Controls.Add(picanimal1[i+1]);

                lblid.Top = left;lblid.Left = 10; lblid.Width = 200;lblid.Font = new Font("Arial", 10, FontStyle.Regular); 
                 picanimal1[i + 1].Top = left; picanimal1[i + 1].Left = 500;
                left = left + 25;
                lblname.Top = left;lblname.Left = 10; lblname.Width = 200; lblname.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblstatus.Top = left; lblstatus.Left = 10; lblstatus.Width = 200; lblstatus.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblspecies.Top = left; lblspecies.Left = 10; lblspecies.Width = 200; lblspecies.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblgender.Top = left; lblgender.Left = 10; lblgender.Width = 200; lblgender.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lbldob.Top = left; lbldob.Left = 10; lbldob.Width = 200; lbldob.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblbornorarrived.Top = left; lblbornorarrived.Left = 10; lblbornorarrived.Width = 200; lblbornorarrived.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 25;
                lblhealth.Top = left; lblhealth.Left = 10; lblhealth.Width = 200; lblhealth.Font = new Font("Arial", 10, FontStyle.Regular); left = left + 60;
                picanimal1[i + 1].Height = 200;
                picanimal1[i + 1].Width = 150;
                picanimal1[i + 1].SizeMode = PictureBoxSizeMode.Zoom;                



            }
        }

        private void ShowAnimal_Load(object sender, EventArgs e)
        {
            btnback.Visible = true;

            if (CaretakerLogin.role == "caretaker")
            {
                btnback.Visible = false;
            }
            if(VeterinarianLogin.role == "vet")
            {
                btnback.Visible = false;
            }
            CaretakerLogin.role = "";
            VeterinarianLogin.role = "";
        }
    }
}
