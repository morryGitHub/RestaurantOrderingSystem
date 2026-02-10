namespace RestaurantOrderingSystem
{
    partial class FrmCancelReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.dgvMatchingReservation = new System.Windows.Forms.DataGridView();
            this.rbCustName = new System.Windows.Forms.RadioButton();
            this.rbPhoneNum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(299, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Find Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(97, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(211, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(219, 41);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(161, 30);
            this.tbCustName.TabIndex = 7;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.Location = new System.Drawing.Point(219, 100);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(161, 30);
            this.tbPhoneNum.TabIndex = 8;
            // 
            // dgvMatchingReservation
            // 
            this.dgvMatchingReservation.AllowUserToAddRows = false;
            this.dgvMatchingReservation.AllowUserToDeleteRows = false;
            this.dgvMatchingReservation.AllowUserToResizeColumns = false;
            this.dgvMatchingReservation.AllowUserToResizeRows = false;
            this.dgvMatchingReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchingReservation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchingReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatchingReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchingReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.Phone,
            this.Date,
            this.Time,
            this.Guests,
            this.Table});
            this.dgvMatchingReservation.EnableHeadersVisualStyles = false;
            this.dgvMatchingReservation.Location = new System.Drawing.Point(6, 37);
            this.dgvMatchingReservation.MultiSelect = false;
            this.dgvMatchingReservation.Name = "dgvMatchingReservation";
            this.dgvMatchingReservation.ReadOnly = true;
            this.dgvMatchingReservation.RowHeadersVisible = false;
            this.dgvMatchingReservation.RowHeadersWidth = 51;
            this.dgvMatchingReservation.RowTemplate.Height = 24;
            this.dgvMatchingReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchingReservation.Size = new System.Drawing.Size(667, 146);
            this.dgvMatchingReservation.TabIndex = 4;
            // 
            // rbCustName
            // 
            this.rbCustName.AutoSize = true;
            this.rbCustName.Checked = true;
            this.rbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustName.Location = new System.Drawing.Point(19, 37);
            this.rbCustName.Name = "rbCustName";
            this.rbCustName.Size = new System.Drawing.Size(125, 32);
            this.rbCustName.TabIndex = 9;
            this.rbCustName.TabStop = true;
            this.rbCustName.Text = "Full Name:";
            this.rbCustName.UseVisualStyleBackColor = true;
            // 
            // rbPhoneNum
            // 
            this.rbPhoneNum.AutoSize = true;
            this.rbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoneNum.Location = new System.Drawing.Point(19, 96);
            this.rbPhoneNum.Name = "rbPhoneNum";
            this.rbPhoneNum.Size = new System.Drawing.Size(169, 32);
            this.rbPhoneNum.TabIndex = 10;
            this.rbPhoneNum.Text = "Phone Number:";
            this.rbPhoneNum.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPhoneNum);
            this.groupBox1.Controls.Add(this.rbCustName);
            this.groupBox1.Controls.Add(this.tbPhoneNum);
            this.groupBox1.Controls.Add(this.tbCustName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 202);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMatchingReservation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 189);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matching Reservation";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 550);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 40);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.Location = new System.Drawing.Point(112, 550);
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(185, 40);
            this.btnCancelReservation.TabIndex = 22;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 113.5829F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.FillWeight = 113.5829F;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 113.5829F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.FillWeight = 113.5829F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Guests
            // 
            this.Guests.FillWeight = 70F;
            this.Guests.HeaderText = "Guests";
            this.Guests.MinimumWidth = 6;
            this.Guests.Name = "Guests";
            this.Guests.ReadOnly = true;
            // 
            // Table
            // 
            this.Table.FillWeight = 60F;
            this.Table.HeaderText = "Table";
            this.Table.MinimumWidth = 6;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            // 
            // frmFindReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 631);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFindReservation";
            this.Text = "Find Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.DataGridView dgvMatchingReservation;
        private System.Windows.Forms.RadioButton rbCustName;
        private System.Windows.Forms.RadioButton rbPhoneNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
    }
}