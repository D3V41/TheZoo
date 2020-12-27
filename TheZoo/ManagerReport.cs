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
    public partial class ManagerReport : UserControl
    {
        public ManagerReport()
        {
            InitializeComponent();
            btnCleanreport.BackColor = Color.LightGray;
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button1.Visible = false;
            button2.Visible = false;

            cleaningpanel2.AutoScroll = false;


        }


        private void textMammel_Click(object sender, EventArgs e)
        {
            textMammel.Text = "";
        }

        private void textBird_Click(object sender, EventArgs e)
        {
            textBird.Text = "";
        }

        private void textReptile_Click(object sender, EventArgs e)
        {
            textReptile.Text = "";
        }

        private void textFish_Click(object sender, EventArgs e)
        {
            textFish.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReport.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ManagerReport_Load_1(object sender, EventArgs e)
        {
            textBird.Text = "0";
            textReptile.Text = "0";
            textMammel.Text = "0";
            textFish.Text = "0";
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReport.Clear();
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

            if(saveFile.ShowDialog() == DialogResult.OK)
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtfReport.Clear();
            rtfReport.AppendText(Environment.NewLine);

            rtfReport.AppendText("\t\t\t\t" + "TheZoo" + Environment.NewLine);
            rtfReport.AppendText("=========================================="+ Environment.NewLine);
            rtfReport.AppendText("Cleaning Report.........." + Environment.NewLine + Environment.NewLine);
            rtfReport.AppendText("Number of days to take clean mammal's division is : " +textMammel.Text+Environment.NewLine);
            rtfReport.AppendText("Number of days to take clean bird's division is : " + textBird.Text + Environment.NewLine);
            rtfReport.AppendText("Number of days to take clean reptile's division is : " + textReptile.Text + Environment.NewLine);
            rtfReport.AppendText("Number of days to take clean fish's division is : " + textFish.Text + Environment.NewLine+Environment.NewLine);
            rtfReport.AppendText("Date : " + lblDate.Text + Environment.NewLine);
            rtfReport.AppendText("Time : " + lblTime.Text + Environment.NewLine);

            Report report = new Report();
            String message = report.DeleteCReport();
            //MessageBox.Show(message);

            message = report.AddCReport(rtfReport.Text);

            //MessageBox.Show(message);

        }

        private void btnCleanreport_Click(object sender, EventArgs e)
        {
            btnCleanreport.BackColor = Color.LightGray;
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            cleaningpanel1.Visible = true;
            rtfReport.Visible = true;
            toolStrip1.Visible = true;
            btnGenerate.Visible = true;

            cleaningpanel2.AutoScroll = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCleanreport.BackColor = SystemColors.Control;
            button1.BackColor = Color.LightGray;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            cleaningpanel1.Visible = false;
            rtfReport.Visible = false;
            toolStrip1.Visible = false;
            btnGenerate.Visible = false;

            cleaningpanel2.Controls.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCleanreport.BackColor = SystemColors.Control;
            button1.BackColor = SystemColors.Control;
            button2.BackColor = Color.LightGray;
            button3.BackColor = SystemColors.Control;
            cleaningpanel1.Visible = false;
            rtfReport.Visible = false;
            toolStrip1.Visible = false;
            btnGenerate.Visible = false;

            cleaningpanel2.Controls.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnCleanreport.BackColor = SystemColors.Control;
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = Color.LightGray;
            cleaningpanel1.Visible = false;
            rtfReport.Visible = false;
            toolStrip1.Visible = false;
            btnGenerate.Visible = false;

            cleaningpanel2.AutoScroll = true;



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

            label.Top = 20; label.Font = new Font("Arial", 15, FontStyle.Regular);label.Dock = DockStyle.Fill;
            cleaningpanel2.Controls.Add(label);
        }

        private void cleaningpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
