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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpReservationDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(248, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Reservation";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(8, 35);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(84, 21);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Full Name:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(5, 76);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(119, 21);
            this.lblPhoneNum.TabIndex = 2;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(131, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Reservation Date:";
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuests.Location = new System.Drawing.Point(8, 124);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(137, 21);
            this.lblNumOfGuests.TabIndex = 4;
            this.lblNumOfGuests.Text = "Number of Guests";
            // 
            // btnFindAvailableTables
            // 
            this.btnFindAvailableTables.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAvailableTables.Location = new System.Drawing.Point(13, 26);
            this.btnFindAvailableTables.Name = "btnFindAvailableTables";
            this.btnFindAvailableTables.Size = new System.Drawing.Size(350, 30);
            this.btnFindAvailableTables.TabIndex = 5;
            this.btnFindAvailableTables.Text = "Find Available Tables";
            this.btnFindAvailableTables.UseVisualStyleBackColor = true;
            this.btnFindAvailableTables.Click += new System.EventHandler(this.BtnFindAvailableTables_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(351, 460);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(193, 46);
            this.btnAddReservation.TabIndex = 8;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(125, 32);
            this.tbCustName.MaxLength = 25;
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(134, 29);
            this.tbCustName.TabIndex = 10;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(125, 74);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(134, 29);
            this.tbPhoneNumber.TabIndex = 11;
            // 
            // numericNumOfGuests
            // 
            this.numericNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumOfGuests.Location = new System.Drawing.Point(154, 126);
            this.numericNumOfGuests.Name = "numericNumOfGuests";
            this.numericNumOfGuests.Size = new System.Drawing.Size(106, 26);
            this.numericNumOfGuests.TabIndex = 14;
            this.numericNumOfGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNumOfGuests.ValueChanged += new System.EventHandler(this.NumericNumOfGuests_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(154, 40);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(108, 26);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged_1);
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableID,
            this.TableNo,
            this.Capacity,
            this.Location});
            this.dgvTables.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTables.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTables.EnableHeadersVisualStyles = false;
            this.dgvTables.Location = new System.Drawing.Point(13, 74);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTables.RowHeadersVisible = false;
            this.dgvTables.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvTables.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(350, 251);
            this.dgvTables.TabIndex = 16;
            // 
            // TableID
            // 
            this.TableID.HeaderText = "TableID";
            this.TableID.MinimumWidth = 6;
            this.TableID.Name = "TableID";
            this.TableID.ReadOnly = true;
            this.TableID.Visible = false;
            // 
            // TableNo
            // 
            this.TableNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.TableNo.HeaderText = "TableNo";
            this.TableNo.MinimumWidth = 6;
            this.TableNo.Name = "TableNo";
            this.TableNo.ReadOnly = true;
            this.TableNo.Width = 110;
            // 
            // Capacity
            // 
            this.Capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 112;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
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
            this.grpCustomerInfo.Location = new System.Drawing.Point(22, 68);
            this.grpCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomerInfo.Size = new System.Drawing.Size(274, 170);
            this.grpCustomerInfo.TabIndex = 17;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Details";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(81, 120);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 29);
            this.tbEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(5, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
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
            this.grpReservationDetails.Location = new System.Drawing.Point(22, 242);
            this.grpReservationDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpReservationDetails.Size = new System.Drawing.Size(274, 171);
            this.grpReservationDetails.TabIndex = 18;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(8, 82);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 21);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Reservation Time:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(154, 81);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(108, 26);
            this.timePicker.TabIndex = 17;
            this.timePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindAvailableTables);
            this.groupBox3.Controls.Add(this.lblErrorMsg);
            this.groupBox3.Controls.Add(this.dgvTables);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(320, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(367, 345);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Availbale Tables";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(12, 74);
            this.lblErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(351, 253);
            this.lblErrorMsg.TabIndex = 17;
            this.lblErrorMsg.Text = "No Available Tables For This Date";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(103, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 46);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // FrmAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 537);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAddReservation";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.FrmAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvTables;
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
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationBar;
    }
}