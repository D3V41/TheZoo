namespace TheZoo
{
    partial class ShowAnimal
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
            this.showheader = new System.Windows.Forms.Panel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfish = new System.Windows.Forms.Button();
            this.btnreptile = new System.Windows.Forms.Button();
            this.btnbird = new System.Windows.Forms.Button();
            this.btnmammal = new System.Windows.Forms.Button();
            this.showfish = new System.Windows.Forms.Panel();
            this.showreptile = new System.Windows.Forms.Panel();
            this.showbird = new System.Windows.Forms.Panel();
            this.showmammal = new System.Windows.Forms.Panel();
            this.searchAnimals2 = new TheZoo.SearchAnimals();
            this.searchAnimals1 = new TheZoo.SearchAnimals();
            this.showheader.SuspendLayout();
            this.showfish.SuspendLayout();
            this.showreptile.SuspendLayout();
            this.showbird.SuspendLayout();
            this.showmammal.SuspendLayout();
            this.SuspendLayout();
            // 
            // showheader
            // 
            this.showheader.BackColor = System.Drawing.SystemColors.Control;
            this.showheader.Controls.Add(this.btnBack2);
            this.showheader.Controls.Add(this.txtsearchbar);
            this.showheader.Controls.Add(this.btnSearch);
            this.showheader.Controls.Add(this.btnback);
            this.showheader.Controls.Add(this.btnfish);
            this.showheader.Controls.Add(this.btnreptile);
            this.showheader.Controls.Add(this.btnbird);
            this.showheader.Controls.Add(this.btnmammal);
            this.showheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.showheader.Location = new System.Drawing.Point(0, 0);
            this.showheader.Name = "showheader";
            this.showheader.Size = new System.Drawing.Size(1345, 58);
            this.showheader.TabIndex = 0;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(993, 0);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(176, 58);
            this.btnBack2.TabIndex = 7;
            this.btnBack2.Text = "<<Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.AccessibleDescription = "";
            this.txtsearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbar.Location = new System.Drawing.Point(0, 8);
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(337, 44);
            this.txtsearchbar.TabIndex = 5;
            this.txtsearchbar.Click += new System.EventHandler(this.txtsearchbar_Click);
            this.txtsearchbar.TextChanged += new System.EventHandler(this.txtsearchbar_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(337, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 58);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnback.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1169, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(176, 58);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "<<Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfish
            // 
            this.btnfish.FlatAppearance.BorderSize = 0;
            this.btnfish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfish.Location = new System.Drawing.Point(888, 4);
            this.btnfish.Name = "btnfish";
            this.btnfish.Size = new System.Drawing.Size(41, 58);
            this.btnfish.TabIndex = 3;
            this.btnfish.Text = "Fish";
            this.btnfish.UseVisualStyleBackColor = true;
            this.btnfish.Visible = false;
            this.btnfish.Click += new System.EventHandler(this.btnfish_Click);
            // 
            // btnreptile
            // 
            this.btnreptile.FlatAppearance.BorderSize = 0;
            this.btnreptile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreptile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreptile.Location = new System.Drawing.Point(841, 4);
            this.btnreptile.Name = "btnreptile";
            this.btnreptile.Size = new System.Drawing.Size(41, 58);
            this.btnreptile.TabIndex = 2;
            this.btnreptile.Text = "Reptile";
            this.btnreptile.UseVisualStyleBackColor = true;
            this.btnreptile.Visible = false;
            this.btnreptile.Click += new System.EventHandler(this.btnreptile_Click);
            // 
            // btnbird
            // 
            this.btnbird.FlatAppearance.BorderSize = 0;
            this.btnbird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbird.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbird.Location = new System.Drawing.Point(794, 3);
            this.btnbird.Name = "btnbird";
            this.btnbird.Size = new System.Drawing.Size(41, 58);
            this.btnbird.TabIndex = 1;
            this.btnbird.Text = "Bird";
            this.btnbird.UseVisualStyleBackColor = true;
            this.btnbird.Visible = false;
            this.btnbird.Click += new System.EventHandler(this.btnbird_Click);
            // 
            // btnmammal
            // 
            this.btnmammal.FlatAppearance.BorderSize = 0;
            this.btnmammal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmammal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmammal.Location = new System.Drawing.Point(743, 4);
            this.btnmammal.Name = "btnmammal";
            this.btnmammal.Size = new System.Drawing.Size(45, 58);
            this.btnmammal.TabIndex = 0;
            this.btnmammal.Text = "Mammmal";
            this.btnmammal.UseVisualStyleBackColor = true;
            this.btnmammal.Visible = false;
            this.btnmammal.Click += new System.EventHandler(this.btnmammal_Click);
            // 
            // showfish
            // 
            this.showfish.AutoScroll = true;
            this.showfish.Controls.Add(this.showreptile);
            this.showfish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showfish.Location = new System.Drawing.Point(0, 58);
            this.showfish.Name = "showfish";
            this.showfish.Size = new System.Drawing.Size(1345, 705);
            this.showfish.TabIndex = 1;
            // 
            // showreptile
            // 
            this.showreptile.AutoScroll = true;
            this.showreptile.Controls.Add(this.showbird);
            this.showreptile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showreptile.Location = new System.Drawing.Point(0, 0);
            this.showreptile.Name = "showreptile";
            this.showreptile.Size = new System.Drawing.Size(1345, 705);
            this.showreptile.TabIndex = 0;
            // 
            // showbird
            // 
            this.showbird.AutoScroll = true;
            this.showbird.Controls.Add(this.showmammal);
            this.showbird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showbird.Location = new System.Drawing.Point(0, 0);
            this.showbird.Name = "showbird";
            this.showbird.Size = new System.Drawing.Size(1345, 705);
            this.showbird.TabIndex = 0;
            // 
            // showmammal
            // 
            this.showmammal.AutoScroll = true;
            this.showmammal.Controls.Add(this.searchAnimals2);
            this.showmammal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showmammal.Location = new System.Drawing.Point(0, 0);
            this.showmammal.Name = "showmammal";
            this.showmammal.Size = new System.Drawing.Size(1345, 705);
            this.showmammal.TabIndex = 0;
            this.showmammal.Paint += new System.Windows.Forms.PaintEventHandler(this.showmammal_Paint);
            // 
            // searchAnimals2
            // 
            this.searchAnimals2.AutoScroll = true;
            this.searchAnimals2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAnimals2.Location = new System.Drawing.Point(0, 0);
            this.searchAnimals2.Name = "searchAnimals2";
            this.searchAnimals2.Size = new System.Drawing.Size(1345, 705);
            this.searchAnimals2.TabIndex = 0;
            // 
            // searchAnimals1
            // 
            this.searchAnimals1.AutoScroll = true;
            this.searchAnimals1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAnimals1.Location = new System.Drawing.Point(0, 0);
            this.searchAnimals1.Name = "searchAnimals1";
            this.searchAnimals1.Size = new System.Drawing.Size(1345, 705);
            this.searchAnimals1.TabIndex = 0;
            // 
            // ShowAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showfish);
            this.Controls.Add(this.showheader);
            this.Name = "ShowAnimal";
            this.Size = new System.Drawing.Size(1345, 763);
            this.Load += new System.EventHandler(this.ShowAnimal_Load);
            this.showheader.ResumeLayout(false);
            this.showheader.PerformLayout();
            this.showfish.ResumeLayout(false);
            this.showreptile.ResumeLayout(false);
            this.showbird.ResumeLayout(false);
            this.showmammal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showheader;
        private System.Windows.Forms.Panel showfish;
        private System.Windows.Forms.Panel showreptile;
        private System.Windows.Forms.Panel showbird;
        private System.Windows.Forms.Panel showmammal;
        private System.Windows.Forms.Button btnfish;
        private System.Windows.Forms.Button btnreptile;
        private System.Windows.Forms.Button btnbird;
        private System.Windows.Forms.Button btnmammal;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearchbar;
        private SearchAnimals searchAnimals1;
        private System.Windows.Forms.Button btnBack2;
        private SearchAnimals searchAnimals2;
    }
}
