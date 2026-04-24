namespace RestaurantOrderingSystem
{
    partial class FrmUpdateTable
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.numSeats = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblTabeNo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.Location = new System.Drawing.Point(21, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 28);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbStatus.Location = new System.Drawing.Point(203, 170);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 31);
            this.cmbStatus.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLocation);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.cmbTableNo);
            this.groupBox1.Controls.Add(this.numSeats);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblTabeNo);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(421, 281);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Details";
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(203, 220);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(189, 34);
            this.tbLocation.TabIndex = 15;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLocation.Location = new System.Drawing.Point(21, 228);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 28);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location";
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.Items.AddRange(new object[] {
            "TableId 4 - 4 seats",
            "TableId 10 - 9 seats"});
            this.cmbTableNo.Location = new System.Drawing.Point(203, 52);
            this.cmbTableNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(189, 31);
            this.cmbTableNo.TabIndex = 13;
            this.cmbTableNo.SelectedIndexChanged += new System.EventHandler(this.CmbTableNo_SelectedIndexChanged);
            // 
            // numSeats
            // 
            this.numSeats.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.numSeats.Location = new System.Drawing.Point(203, 107);
            this.numSeats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numSeats.Name = "numSeats";
            this.numSeats.Size = new System.Drawing.Size(191, 30);
            this.numSeats.TabIndex = 4;
            this.numSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(21, 107);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(158, 28);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "Seating Capacity";
            // 
            // lblTabeNo
            // 
            this.lblTabeNo.AutoSize = true;
            this.lblTabeNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTabeNo.Location = new System.Drawing.Point(21, 52);
            this.lblTabeNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTabeNo.Name = "lblTabeNo";
            this.lblTabeNo.Size = new System.Drawing.Size(134, 28);
            this.lblTabeNo.TabIndex = 1;
            this.lblTabeNo.Text = "Table Number";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(48, 409);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 44);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTable.Location = new System.Drawing.Point(281, 409);
            this.btnUpdateTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(133, 44);
            this.btnUpdateTable.TabIndex = 12;
            this.btnUpdateTable.Text = "Update Table";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            this.btnUpdateTable.Click += new System.EventHandler(this.BtnUpdateTable_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(117, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 38);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Update Table";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 30);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // FrmUpdateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateTable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUpdateTable";
            this.Text = "UpdateTableForm";
            this.Load += new System.EventHandler(this.UpdateTableForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeats)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSeats;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblTabeNo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbLocation;
    }
}