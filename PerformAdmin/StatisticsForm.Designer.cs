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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataStat = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStat)).BeginInit();
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Options";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(359, 44);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(165, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Statistics";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "Top Item"});
            this.cmbCat.Location = new System.Drawing.Point(174, 46);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(159, 31);
            this.cmbCat.TabIndex = 2;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCat.Location = new System.Drawing.Point(6, 46);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(149, 28);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Select Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(57, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 38);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Print Yearly Revenue Analysis";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.button2.Location = new System.Drawing.Point(23, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataStat);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(17, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 295);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Details";
            // 
            // dataStat
            // 
            this.dataStat.AllowUserToAddRows = false;
            this.dataStat.AllowUserToDeleteRows = false;
            this.dataStat.AllowUserToResizeColumns = false;
            this.dataStat.AllowUserToResizeRows = false;
            this.dataStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Count});
            this.dataStat.Location = new System.Drawing.Point(6, 37);
            this.dataStat.Name = "dataStat";
            this.dataStat.ReadOnly = true;
            this.dataStat.RowHeadersVisible = false;
            this.dataStat.RowHeadersWidth = 51;
            this.dataStat.RowTemplate.Height = 24;
            this.dataStat.Size = new System.Drawing.Size(518, 252);
            this.dataStat.TabIndex = 7;
            // 
            // Item
            // 
            this.Item.HeaderText = "Menu Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Times Ordered";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSummary);
            this.Name = "frmStatistics";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStat)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}