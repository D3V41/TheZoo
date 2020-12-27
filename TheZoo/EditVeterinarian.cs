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
    public partial class EditVeterinarian : UserControl
    {
        public EditVeterinarian()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            String id, dummy;
            id = textBox4.Text;

            Veterinarian veterinarian = new Veterinarian();

            String[] mammals = new String[500];
            int i, size = 100;
            int k = 1;
            int left = 25;

            mammals = veterinarian.EditVeterinarian(id);
            dummy = mammals[k++];

            textBox1.Text = mammals[k++];

            if (mammals[k++] == "Male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

            dateTimePicker1.Value = new DateTime(2020, 01, 28);
            dummy = mammals[k++];


            textBox2.Text = mammals[k++];



            textBox3.Text = mammals[k++];




        }

        private void button2_Click(object sender, EventArgs e)
        {

            String name, gender, email, mobile;
            DateTime date;

            name = textBox1.Text;

            if (radioButton1.Checked == true)
                gender = "Male";
            else
                gender = "Female";

            date = dateTimePicker1.Value.Date;

            email = textBox2.Text;

            mobile = textBox3.Text;


            Veterinarian veterinarian = new Veterinarian(name, gender, mobile, email, date);

            String message = veterinarian.UpdateVeterinarian(textBox4.Text);

            MessageBox.Show(message);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinarian veterinarian = new Veterinarian();
            String message = veterinarian.DeleteVeterinarian(textBox4.Text);

            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
