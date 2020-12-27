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
    public partial class AddCaretaker : UserControl
    {
        public AddCaretaker()
        {
            InitializeComponent();
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


            Caretaker caretaker = new Caretaker(name,gender,mobile,email,date);

            String message = caretaker.AddCaretake();

            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
