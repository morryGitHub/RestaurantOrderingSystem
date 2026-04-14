namespace RestaurantOrderingSystem
{
    partial class FrmStatistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSummary = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(28, 319);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(0, 16);
            this.lblSummary.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.cmbCat);
            this.groupBox1.Controls.Add(this.lblCat);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Options";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(429, 44);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Top 10 Menu Items",
            "Least 10 Menu Items",
            "Never Ordered Items",
            "Total Orders",
            "Average Order",
            "Total Revenue",
            "Total Bookings",
            "Payments By Method",
            "Total Refunded Amount"});
            this.cmbCat.Location = new System.Drawing.Point(171, 46);
            this.cmbCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(233, 31);
            this.cmbCat.TabIndex = 2;
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.CmbCat_SelectedIndexChanged);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCat.Location = new System.Drawing.Point(5, 46);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(149, 28);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Select Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(109, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 38);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Print Yearly Revenue Analysis";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStats);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(17, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(571, 389);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Details";
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AllowUserToResizeColumns = false;
            this.dgvStats.AllowUserToResizeRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.GridColor = System.Drawing.Color.Black;
            this.dgvStats.Location = new System.Drawing.Point(5, 37);
            this.dgvStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.RowHeadersWidth = 51;
            this.dgvStats.RowTemplate.Height = 24;
            this.dgvStats.Size = new System.Drawing.Size(559, 348);
            this.dgvStats.TabIndex = 7;
            this.dgvStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStat_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStatistics";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}