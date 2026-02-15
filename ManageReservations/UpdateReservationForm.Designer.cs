namespace RestaurantOrderingSystem
{
    partial class frmUpdateReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.btnFindAvailableTables = new System.Windows.Forms.Button();
            this.lblTableInfoText = new System.Windows.Forms.Label();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.TableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTableNo = new System.Windows.Forms.TextBox();
            this.lblTableText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.blbDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.numericNumOfGuests = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTableInfo);
            this.groupBox3.Controls.Add(this.btnFindAvailableTables);
            this.groupBox3.Controls.Add(this.lblTableInfoText);
            this.groupBox3.Controls.Add(this.dgvTables);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(443, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 480);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Availbale Tables";
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableInfo.Location = new System.Drawing.Point(118, 423);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(311, 51);
            this.lblTableInfo.TabIndex = 21;
            this.lblTableInfo.Text = "No info yet.";
            this.lblTableInfo.Click += new System.EventHandler(this.lblTableInfo_Click);
            // 
            // btnFindAvailableTables
            // 
            this.btnFindAvailableTables.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAvailableTables.Location = new System.Drawing.Point(16, 40);
            this.btnFindAvailableTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAvailableTables.Name = "btnFindAvailableTables";
            this.btnFindAvailableTables.Size = new System.Drawing.Size(413, 37);
            this.btnFindAvailableTables.TabIndex = 5;
            this.btnFindAvailableTables.Text = "Find Available Tables";
            this.btnFindAvailableTables.UseVisualStyleBackColor = true;
            this.btnFindAvailableTables.Click += new System.EventHandler(this.btnFindAvailableTables_Click);
            // 
            // lblTableInfoText
            // 
            this.lblTableInfoText.AutoSize = true;
            this.lblTableInfoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableInfoText.Location = new System.Drawing.Point(12, 423);
            this.lblTableInfoText.Name = "lblTableInfoText";
            this.lblTableInfoText.Size = new System.Drawing.Size(100, 28);
            this.lblTableInfoText.TabIndex = 20;
            this.lblTableInfoText.Text = "Table Info:";
            this.lblTableInfoText.Click += new System.EventHandler(this.lblTableInfoText_Click);
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableNo,
            this.Capacity,
            this.Status});
            this.dgvTables.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTables.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTables.EnableHeadersVisualStyles = false;
            this.dgvTables.Location = new System.Drawing.Point(17, 91);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RowHeadersVisible = false;
            this.dgvTables.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvTables.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(413, 312);
            this.dgvTables.TabIndex = 16;
            this.dgvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellContentClick);
            // 
            // TableNo
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNo.DefaultCellStyle = dataGridViewCellStyle13;
            this.TableNo.HeaderText = "TableNo";
            this.TableNo.MinimumWidth = 6;
            this.TableNo.Name = "TableNo";
            this.TableNo.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.tbTableNo);
            this.groupBox2.Controls.Add(this.lblTableText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.timePicker);
            this.groupBox2.Controls.Add(this.blbDate);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.lblNumOfGuests);
            this.groupBox2.Controls.Add(this.numericNumOfGuests);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 308);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation Details";
            // 
            // tbTableNo
            // 
            this.tbTableNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableNo.Location = new System.Drawing.Point(206, 201);
            this.tbTableNo.Name = "tbTableNo";
            this.tbTableNo.ReadOnly = true;
            this.tbTableNo.Size = new System.Drawing.Size(139, 30);
            this.tbTableNo.TabIndex = 19;
            // 
            // lblTableText
            // 
            this.lblTableText.AutoSize = true;
            this.lblTableText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableText.Location = new System.Drawing.Point(11, 201);
            this.lblTableText.Name = "lblTableText";
            this.lblTableText.Size = new System.Drawing.Size(131, 28);
            this.lblTableText.TabIndex = 18;
            this.lblTableText.Text = "Current Table:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reservation Time:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(206, 100);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(142, 30);
            this.timePicker.TabIndex = 17;
            // 
            // blbDate
            // 
            this.blbDate.AutoSize = true;
            this.blbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbDate.Location = new System.Drawing.Point(11, 50);
            this.blbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blbDate.Name = "blbDate";
            this.blbDate.Size = new System.Drawing.Size(163, 28);
            this.blbDate.TabIndex = 3;
            this.blbDate.Text = "Reservation Date:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(206, 49);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 30);
            this.datePicker.TabIndex = 15;
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuests.Location = new System.Drawing.Point(11, 152);
            this.lblNumOfGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(174, 28);
            this.lblNumOfGuests.TabIndex = 4;
            this.lblNumOfGuests.Text = "Number of Guests:";
            // 
            // numericNumOfGuests
            // 
            this.numericNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumOfGuests.Location = new System.Drawing.Point(206, 155);
            this.numericNumOfGuests.Margin = new System.Windows.Forms.Padding(4);
            this.numericNumOfGuests.Name = "numericNumOfGuests";
            this.numericNumOfGuests.Size = new System.Drawing.Size(142, 30);
            this.numericNumOfGuests.TabIndex = 14;
            this.numericNumOfGuests.ValueChanged += new System.EventHandler(this.numericNumOfGuests_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.tbCustName);
            this.groupBox1.Controls.Add(this.lblPhoneNum);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(167, 91);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(178, 34);
            this.tbPhoneNumber.TabIndex = 11;
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(167, 40);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustName.MaxLength = 25;
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(178, 34);
            this.tbCustName.TabIndex = 10;
            this.tbCustName.TextChanged += new System.EventHandler(this.tbCustName_TextChanged_1);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(7, 94);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(148, 28);
            this.lblPhoneNum.TabIndex = 2;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(11, 43);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(104, 28);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Full Name:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(153, 600);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(257, 48);
            this.btnAddReservation.TabIndex = 23;
            this.btnAddReservation.Text = "Update Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(322, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 38);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Reservation Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(460, 600);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 48);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(11, 251);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 28);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Reseravtion Status:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Booked",
            "Cancelled",
            "Seated"});
            this.comboBox1.Location = new System.Drawing.Point(203, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 31);
            this.comboBox1.TabIndex = 21;
            // 
            // frmUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 720);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmUpdateReservation";
            this.Text = "Update Reservation";
            this.Load += new System.EventHandler(this.UpdateReservationForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFindAvailableTables;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label blbDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.NumericUpDown numericNumOfGuests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTableText;
        private System.Windows.Forms.TextBox tbTableNo;
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.Label lblTableInfoText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStatus;
    }
}