namespace RestaurantOrderingSystem
{
    partial class AddTableForm
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
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.numericTableNo = new System.Windows.Forms.NumericUpDown();
            this.numericSeatingCap = new System.Windows.Forms.NumericUpDown();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTableNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeatingCap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(126, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Table";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTableNo.Location = new System.Drawing.Point(21, 52);
            this.lblTableNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(134, 28);
            this.lblTableNo.TabIndex = 1;
            this.lblTableNo.Text = "Table Number";
            this.lblTableNo.Click += new System.EventHandler(this.lblTableNo_Click);
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
            // numericTableNo
            // 
            this.numericTableNo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.numericTableNo.Location = new System.Drawing.Point(205, 55);
            this.numericTableNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericTableNo.Name = "numericTableNo";
            this.numericTableNo.Size = new System.Drawing.Size(123, 30);
            this.numericTableNo.TabIndex = 3;
            // 
            // numericSeatingCap
            // 
            this.numericSeatingCap.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.numericSeatingCap.Location = new System.Drawing.Point(205, 110);
            this.numericSeatingCap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericSeatingCap.Name = "numericSeatingCap";
            this.numericSeatingCap.Size = new System.Drawing.Size(123, 30);
            this.numericSeatingCap.TabIndex = 4;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Location = new System.Drawing.Point(30, 327);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(134, 44);
            this.btnAddTable.TabIndex = 5;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(254, 327);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericSeatingCap);
            this.groupBox1.Controls.Add(this.numericTableNo);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblTableNo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(358, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddTableForm";
            this.Text = "AddTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericTableNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeatingCap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numericTableNo;
        private System.Windows.Forms.NumericUpDown numericSeatingCap;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}