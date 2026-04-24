namespace RestaurantOrderingSystem
{
    partial class FrmAddReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.btnFindAvailableTables = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.numericNumOfGuests = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.dgvAddTables = new System.Windows.Forms.DataGridView();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpReservationDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTables)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(331, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Reservation";
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 50);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(163, 28);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Reservation Date:";
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuests.Location = new System.Drawing.Point(11, 153);
            this.lblNumOfGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(170, 28);
            this.lblNumOfGuests.TabIndex = 4;
            this.lblNumOfGuests.Text = "Number of Guests";
            // 
            // btnFindAvailableTables
            // 
            this.btnFindAvailableTables.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAvailableTables.Location = new System.Drawing.Point(16, 37);
            this.btnFindAvailableTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAvailableTables.Name = "btnFindAvailableTables";
            this.btnFindAvailableTables.Size = new System.Drawing.Size(483, 37);
            this.btnFindAvailableTables.TabIndex = 5;
            this.btnFindAvailableTables.Text = "Find Available Tables";
            this.btnFindAvailableTables.UseVisualStyleBackColor = true;
            this.btnFindAvailableTables.Click += new System.EventHandler(this.BtnFindAvailableTables_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(468, 566);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(257, 57);
            this.btnAddReservation.TabIndex = 8;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(167, 39);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustName.MaxLength = 25;
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(177, 34);
            this.tbCustName.TabIndex = 10;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(167, 91);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(177, 34);
            this.tbPhoneNumber.TabIndex = 11;
            // 
            // numericNumOfGuests
            // 
            this.numericNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumOfGuests.Location = new System.Drawing.Point(205, 155);
            this.numericNumOfGuests.Margin = new System.Windows.Forms.Padding(4);
            this.numericNumOfGuests.Name = "numericNumOfGuests";
            this.numericNumOfGuests.Size = new System.Drawing.Size(141, 30);
            this.numericNumOfGuests.TabIndex = 14;
            this.numericNumOfGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumOfGuests.ValueChanged += new System.EventHandler(this.NumericNumOfGuests_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(205, 49);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(143, 30);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged_1);
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.tbEmail);
            this.grpCustomerInfo.Controls.Add(this.lblEmail);
            this.grpCustomerInfo.Controls.Add(this.tbPhoneNumber);
            this.grpCustomerInfo.Controls.Add(this.tbCustName);
            this.grpCustomerInfo.Controls.Add(this.lblPhoneNum);
            this.grpCustomerInfo.Controls.Add(this.lblCustName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(29, 84);
            this.grpCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerInfo.Size = new System.Drawing.Size(365, 209);
            this.grpCustomerInfo.TabIndex = 17;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Details";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(108, 148);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 34);
            this.tbEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 151);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.lblTime);
            this.grpReservationDetails.Controls.Add(this.timePicker);
            this.grpReservationDetails.Controls.Add(this.lblDate);
            this.grpReservationDetails.Controls.Add(this.datePicker);
            this.grpReservationDetails.Controls.Add(this.lblNumOfGuests);
            this.grpReservationDetails.Controls.Add(this.numericNumOfGuests);
            this.grpReservationDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReservationDetails.Location = new System.Drawing.Point(29, 298);
            this.grpReservationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReservationDetails.Size = new System.Drawing.Size(365, 210);
            this.grpReservationDetails.TabIndex = 18;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(11, 101);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(164, 28);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Reservation Time:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(205, 100);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(143, 30);
            this.timePicker.TabIndex = 17;
            this.timePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindAvailableTables);
            this.groupBox3.Controls.Add(this.dgvAddTables);
            this.groupBox3.Controls.Add(this.lblErrorMsg);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(427, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(509, 425);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Availbale Tables";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(9, 78);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(489, 331);
            this.lblErrorMsg.TabIndex = 17;
            this.lblErrorMsg.Text = "No availability matches your selected criteria.";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // dgvAddTables
            // 
            this.dgvAddTables.AllowUserToAddRows = false;
            this.dgvAddTables.AllowUserToDeleteRows = false;
            this.dgvAddTables.AllowUserToResizeColumns = false;
            this.dgvAddTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableId,
            this.TableNo,
            this.Capacity,
            this.Location});
            this.dgvAddTables.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddTables.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddTables.EnableHeadersVisualStyles = false;
            this.dgvAddTables.Location = new System.Drawing.Point(16, 80);
            this.dgvAddTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAddTables.MultiSelect = false;
            this.dgvAddTables.Name = "dgvAddTables";
            this.dgvAddTables.ReadOnly = true;
            this.dgvAddTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAddTables.RowHeadersVisible = false;
            this.dgvAddTables.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvAddTables.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddTables.RowTemplate.Height = 24;
            this.dgvAddTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddTables.Size = new System.Drawing.Size(479, 329);
            this.dgvAddTables.TabIndex = 18;
            // 
            // TableId
            // 
            this.TableId.HeaderText = "TableId";
            this.TableId.MinimumWidth = 6;
            this.TableId.Name = "TableId";
            this.TableId.ReadOnly = true;
            this.TableId.Visible = false;
            // 
            // TableNo
            // 
            this.TableNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TableNo.HeaderText = "TableNo";
            this.TableNo.MinimumWidth = 6;
            this.TableNo.Name = "TableNo";
            this.TableNo.ReadOnly = true;
            this.TableNo.Width = 131;
            // 
            // Capacity
            // 
            this.Capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 134;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(137, 566);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 57);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // FrmAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 661);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddReservation";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.FrmAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTables)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.Button btnFindAvailableTables;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.NumericUpDown numericNumOfGuests;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAddTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}