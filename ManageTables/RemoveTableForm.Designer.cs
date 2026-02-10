namespace RestaurantOrderingSystem
{
    partial class FrmRemoveTable
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
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.Items.AddRange(new object[] {
            "Table 4 - 4 seats",
            "Table 10 - 9 seats"});
            this.cmbTableNo.Location = new System.Drawing.Point(124, 46);
            this.cmbTableNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(128, 23);
            this.cmbTableNo.TabIndex = 12;
            this.cmbTableNo.SelectedIndexChanged += new System.EventHandler(this.cmbTableNo_SelectedIndexChanged);
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTableNo.Location = new System.Drawing.Point(4, 42);
            this.lblTableNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(110, 21);
            this.lblTableNo.TabIndex = 11;
            this.lblTableNo.Text = "Table Number:";
            this.lblTableNo.Click += new System.EventHandler(this.lblTableNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Delete Table ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(192, 214);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTable.Location = new System.Drawing.Point(23, 214);
            this.btnRemoveTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveTable.TabIndex = 16;
            this.btnRemoveTable.Text = "Delete Table";
            this.btnRemoveTable.UseVisualStyleBackColor = true;
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTableNo);
            this.groupBox1.Controls.Add(this.lblTableNo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(269, 98);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Table";
            // 
            // frmRemoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRemoveTable";
            this.Text = "DeleteTableForm";
            this.Load += new System.EventHandler(this.frmRemoveTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveTable;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}