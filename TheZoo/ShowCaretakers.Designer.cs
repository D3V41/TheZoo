namespace TheZoo
{
    partial class ShowCaretakers
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
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.showcaretaker = new System.Windows.Forms.Panel();
            this.SearchCaretaker = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.showcaretaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.AccessibleDescription = "";
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(2, 10);
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(337, 44);
            this.txtsearchbar.TabIndex = 7;
            this.txtsearchbar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtsearchbar_MouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(339, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.panel1.Size = new System.Drawing.Size(1317, 58);
            this.panel1.TabIndex = 9;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(965, 0);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(176, 58);
            this.btnBack2.TabIndex = 10;
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
            this.btnback.Location = new System.Drawing.Point(1141, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(176, 58);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "<<Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // showcaretaker
            // 
            this.showcaretaker.AutoScroll = true;
            this.showcaretaker.Controls.Add(this.SearchCaretaker);
            this.showcaretaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showcaretaker.Location = new System.Drawing.Point(0, 58);
            this.showcaretaker.Name = "showcaretaker";
            this.showcaretaker.Size = new System.Drawing.Size(1317, 688);
            this.showcaretaker.TabIndex = 10;
            // 
            // SearchCaretaker
            // 
            this.SearchCaretaker.AutoScroll = true;
            this.SearchCaretaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchCaretaker.Location = new System.Drawing.Point(0, 0);
            this.SearchCaretaker.Name = "SearchCaretaker";
            this.SearchCaretaker.Size = new System.Drawing.Size(1317, 688);
            this.SearchCaretaker.TabIndex = 2;
            // 
            // ShowCaretakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showcaretaker);
            this.Controls.Add(this.panel1);
            this.Name = "ShowCaretakers";
            this.Size = new System.Drawing.Size(1317, 746);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.showcaretaker.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearchbar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel showcaretaker;
        private System.Windows.Forms.Panel SearchCaretaker;
    }
}
