namespace RestaurantOrderingSystem
{
    partial class FrmPrintRevenue
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.gridRevenue = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRevenue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(57, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Print Yearly Revenue Analysis";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblYear.Location = new System.Drawing.Point(6, 46);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(105, 28);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Select Year";
            this.lblYear.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2025",
            "2024"});
            this.cmbYear.Location = new System.Drawing.Point(128, 48);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 31);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(276, 46);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(165, 33);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Statistics";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCLose.Location = new System.Drawing.Point(17, 527);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(119, 36);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // gridRevenue
            // 
            this.gridRevenue.AllowUserToAddRows = false;
            this.gridRevenue.AllowUserToDeleteRows = false;
            this.gridRevenue.AllowUserToResizeColumns = false;
            this.gridRevenue.AllowUserToResizeRows = false;
            this.gridRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Revenue});
            this.gridRevenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridRevenue.Location = new System.Drawing.Point(6, 37);
            this.gridRevenue.MultiSelect = false;
            this.gridRevenue.Name = "gridRevenue";
            this.gridRevenue.ReadOnly = true;
            this.gridRevenue.RowHeadersVisible = false;
            this.gridRevenue.RowHeadersWidth = 51;
            this.gridRevenue.RowTemplate.Height = 24;
            this.gridRevenue.Size = new System.Drawing.Size(457, 197);
            this.gridRevenue.TabIndex = 5;
            this.gridRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue ($)";
            this.Revenue.MinimumWidth = 6;
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.gridRevenue);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(17, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 295);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Details";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 28);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: $0.00";
            // 
            // frmPrintRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPrintRevenue";
            this.Text = "PrintRevenueForm";
            this.Load += new System.EventHandler(this.PrintRevenueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRevenue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.DataGridView gridRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
    }
}