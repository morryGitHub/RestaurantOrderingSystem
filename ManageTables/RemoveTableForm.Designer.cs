namespace RestaurantOrderingSystem
{
    partial class frmRemoveTable
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
            this.cmbTableNo.Location = new System.Drawing.Point(166, 56);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(169, 28);
            this.cmbTableNo.TabIndex = 12;
            this.cmbTableNo.SelectedIndexChanged += new System.EventHandler(this.cmbTableNo_SelectedIndexChanged);
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTableNo.Location = new System.Drawing.Point(6, 52);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(138, 28);
            this.lblTableNo.TabIndex = 11;
            this.lblTableNo.Text = "Table Number:";
            this.lblTableNo.Click += new System.EventHandler(this.lblTableNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Delete Table ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(256, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 43);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTable.Location = new System.Drawing.Point(31, 264);
            this.btnRemoveTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(134, 43);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 120);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Table";
            // 
            // frmRemoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveTable);
            this.Controls.Add(this.label1);
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