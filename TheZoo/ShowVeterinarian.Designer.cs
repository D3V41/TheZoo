namespace TheZoo
{
    partial class ShowVeterinarian
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.showvet = new System.Windows.Forms.Panel();
            this.searchvet = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.showvet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack2);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtsearchbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(337, -1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 58);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.AccessibleDescription = "";
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(0, 3);
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(337, 44);
            this.txtsearchbar.TabIndex = 9;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(909, 0);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(176, 62);
            this.btnBack2.TabIndex = 12;
            this.btnBack2.Text = "<<Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnback.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1085, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(176, 62);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "<<Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // showvet
            // 
            this.showvet.Controls.Add(this.searchvet);
            this.showvet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showvet.Location = new System.Drawing.Point(0, 62);
            this.showvet.Name = "showvet";
            this.showvet.Size = new System.Drawing.Size(1261, 667);
            this.showvet.TabIndex = 1;
            // 
            // searchvet
            // 
            this.searchvet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchvet.Location = new System.Drawing.Point(0, 0);
            this.searchvet.Name = "searchvet";
            this.searchvet.Size = new System.Drawing.Size(1261, 667);
            this.searchvet.TabIndex = 0;
            // 
            // ShowVeterinarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showvet);
            this.Controls.Add(this.panel1);
            this.Name = "ShowVeterinarian";
            this.Size = new System.Drawing.Size(1261, 729);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.showvet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearchbar;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel showvet;
        private System.Windows.Forms.Panel searchvet;
    }
}
