﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TheZoo
{
    public partial class AddAnimal : UserControl
    {
        public AddAnimal()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                Thread myThread = new Thread((ThreadStart)delegate {  

                 OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    pictureBox1.ImageLocation = imagelocation;
                }
                });
                myThread.ApartmentState = ApartmentState.STA;
                myThread.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        

        private void AddAnimal_Load(object sender, EventArgs e)
        {

        }

        private void speciesbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (speciesbox.SelectedItem.Equals(""))
            {
                namebox.Items.Add("");
            }
            else if (speciesbox.SelectedItem.Equals("Mammal"))
            {
                namebox.Items.Clear();
                namebox.Items.Add("Leopard");
                namebox.Items.Add("Lion");
                namebox.Items.Add("Bear");
                namebox.Items.Add("Fox");
                namebox.Items.Add("Jaguar");
            }
            else if (speciesbox.SelectedItem.Equals("Bird"))
            {
                namebox.Items.Clear();
                namebox.Items.Add("Peacock");
                namebox.Items.Add("Robin");
                namebox.Items.Add("Woodpecker");
                namebox.Items.Add("Stork");
                namebox.Items.Add("Turkey");
            }
            else if (speciesbox.SelectedItem.Equals("Reptile"))
            {
                namebox.Items.Clear();
                namebox.Items.Add("Alligator");
                namebox.Items.Add("Tortoise");
                namebox.Items.Add("Viper");
                namebox.Items.Add("Cobra");
                namebox.Items.Add("Komodo dragon");
            }
            else if (speciesbox.SelectedItem.Equals("Fish"))
            {
                namebox.Items.Clear();
                namebox.Items.Add("catfish");
                namebox.Items.Add("Billfish");
                namebox.Items.Add("California flyingfish");
                namebox.Items.Add("Electric knifefish");
                namebox.Items.Add("Electric eel");
            }

            this.Controls.Add(namebox);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String species, animalname, animalgender, animalhealth, animalstatus,animalborn;
            DateTime date;
            Image animalimage;

            animalgender = "Male";
            animalstatus = "Alive";
            animalborn = "Born Here";

            species = speciesbox.GetItemText(speciesbox.SelectedItem);
            animalname = namebox.GetItemText(namebox.SelectedItem);

            if (radioButton1.Checked)
                animalgender = "Male";
            if(radioButton2.Checked)
                animalgender = "Female";

            date = dateTimePicker1.Value.Date;

            if (radioButton3.Checked)
                animalborn = "Arrived";
            if (radioButton4.Checked)
                animalborn = "Born Here";

            animalhealth = healthbox.GetItemText(healthbox.SelectedItem);

            if (radioButton5.Checked)
                animalstatus = "Alive";
            if (radioButton6.Checked)
                animalstatus = "Dead";

            animalimage = pictureBox1.Image;

            Animal animal = new Animal(species, animalname, animalgender, animalhealth, animalstatus, animalborn, date, animalimage);

            String message =  animal.AddNewAnimal();


            MessageBox.Show(message);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
