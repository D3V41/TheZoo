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

namespace TheZoo
{
    public partial class VeterinarianReport : UserControl
    {
        StringBuilder helreport = new StringBuilder();
        StringBuilder foodreport = new StringBuilder();

        public VeterinarianReport()
        {
            InitializeComponent();
        }

      

        private void VeterinarianReport_Load(object sender, EventArgs e)
        {
            
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblDate1.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            btnFeedreport.BackColor = Color.LightGray;
            btnHealthreport.BackColor = SystemColors.Control;
            btnShowreport.BackColor = SystemColors.Control;

            btnGenerateFreport.Visible = true;
            btnGenerateHreport.Visible = false;

            feedingpanel1.Visible = true;
            healthpanel2.Visible = false;

            rtfReport.Visible = true;
            toolStrip1.Visible = true;

            label12.Visible = true;
            label9.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.Visible = false;
            textBox1.Visible = false;
            healthbox.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReport.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblTime1.Text = DateTime.Now.ToLongTimeString();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReport.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread myThread = new Thread((ThreadStart)delegate {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    openFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        rtfReport.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                });
                myThread.ApartmentState = ApartmentState.STA;
                myThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread myThread = new Thread((ThreadStart)delegate {
                    SaveFileDialog saveFile = new SaveFileDialog();

                    saveFile.FileName = "Cleaning Report";
                    saveFile.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                            sw.WriteLine(rtfReport.Text);
                    }
                });
                myThread.ApartmentState = ApartmentState.STA;
                myThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReport.Cut();

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReport.Copy();

        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReport.Paste();

        }

        private void btnGenerateHreport_Click(object sender, EventArgs e)
        {

            rtfReport.Clear();
            rtfReport.AppendText(Environment.NewLine);

            rtfReport.AppendText("\t\t\t\t" + "TheZoo" + Environment.NewLine);
            rtfReport.AppendText("==========================================" + Environment.NewLine);
            rtfReport.AppendText("Health Report.........." + Environment.NewLine + Environment.NewLine);
            rtfReport.AppendText(helreport.ToString());
            rtfReport.AppendText("Date : " + lblDate.Text + Environment.NewLine);
            rtfReport.AppendText("Time : " + lblTime.Text + Environment.NewLine);

            Report report = new Report();
            String message = report.DeleteHReport();
            //MessageBox.Show(message);

            message = report.AddHReport(rtfReport.Text);

            helreport.Clear();

            //MessageBox.Show(message);

        }

        private void btnGenerateFreport_Click(object sender, EventArgs e)
        {
            rtfReport.Clear();
            rtfReport.AppendText(Environment.NewLine);

            rtfReport.AppendText("\t\t\t\t" + "TheZoo" + Environment.NewLine);
            rtfReport.AppendText("==========================================" + Environment.NewLine);
            rtfReport.AppendText("Feeding Report.........." + Environment.NewLine + Environment.NewLine);
            rtfReport.AppendText(foodreport.ToString());

            rtfReport.AppendText("Date : " + lblDate.Text + Environment.NewLine);
            rtfReport.AppendText("Time : " + lblTime.Text + Environment.NewLine);

            Report report = new Report();
            String message = report.DeleteFReport();
            //MessageBox.Show(message);

            message = report.AddFReport(rtfReport.Text);

            foodreport.Clear();


            //MessageBox.Show(message);
        }

        private void btnFeedreport_Click(object sender, EventArgs e)
        {
            btnFeedreport.BackColor = Color.LightGray;
            btnHealthreport.BackColor = SystemColors.Control;
            btnShowreport.BackColor = SystemColors.Control;

            btnGenerateFreport.Visible = true;
            btnGenerateHreport.Visible = false;

            feedingpanel1.Visible = true;
            healthpanel2.Visible = false;

            rtfReport.Visible = true;
            toolStrip1.Visible = true;

            rtfReport.Clear();

            label12.Visible = true;
            label9.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            label2.Visible = false;
            textBox1.Visible = false;
            healthbox.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

        }

        private void btnHealthreport_Click(object sender, EventArgs e)
        {
            btnFeedreport.BackColor = SystemColors.Control;
            btnHealthreport.BackColor = Color.LightGray;
            btnShowreport.BackColor = SystemColors.Control;

            btnGenerateFreport.Visible = false;
            btnGenerateHreport.Visible = true;

            feedingpanel1.Visible = true;
            healthpanel2.Visible = true;


            rtfReport.Visible = true;
            toolStrip1.Visible = true;

            rtfReport.Clear();

            label12.Visible = false;
            label9.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = true;
            textBox1.Visible = true;
            healthbox.Visible = true;
            label4.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            button1.Visible = true;

        }

        private void btnShowreport_Click(object sender, EventArgs e)
        {
            btnFeedreport.BackColor = SystemColors.Control;
            btnHealthreport.BackColor = SystemColors.Control;
            btnShowreport.BackColor = Color.LightGray;

            btnGenerateFreport.Visible = false;
            btnGenerateHreport.Visible = false;

            feedingpanel1.Visible = false;
            healthpanel2.Visible = false;

            rtfReport.Visible = false;
            toolStrip1.Visible = false;

            Report report = new Report();
            String rep = report.ShowCReport();

            RichTextBox label = new RichTextBox();
            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            rep = report.ShowFReport();
            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            rep = report.ShowHReport();
            label.AppendText(rep);
            label.AppendText(Environment.NewLine + Environment.NewLine);

            label.Top = 20; label.Font = new Font("Arial", 15, FontStyle.Regular); label.Dock = DockStyle.Fill;
            feedingpanel.Controls.Add(label);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            helreport.AppendLine("Animal ID : " + textBox1.Text);
            if (healthbox.SelectedItem == null)
                healthbox.SelectedItem = "";
            helreport.AppendLine("Health : " + healthbox.SelectedItem.ToString());
            helreport.AppendLine("Medicine : " + textBox2.Text);
            helreport.AppendLine();

            MessageBox.Show("Added!!");
            textBox1.Text = "";
            healthbox.SelectedIndex = -1;
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helreport.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodreport.AppendLine("Animal ID : " + textBox4.Text);
            foodreport.AppendLine("Food : " + textBox3.Text);
            foodreport.AppendLine();

            MessageBox.Show("Added!!");
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foodreport.Clear();

        }
    }
}
