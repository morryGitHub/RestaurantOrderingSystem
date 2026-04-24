namespace RestaurantOrderingSystem
{
    partial class FrmUpdateReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindAvailableTables = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.tbTableCapacity = new System.Windows.Forms.TextBox();
            this.lblTableCapacity = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbTableNo = new System.Windows.Forms.TextBox();
            this.lblTableText = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.numericNumOfGuests = new System.Windows.Forms.NumericUpDown();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.grpReservationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindAvailableTables);
            this.groupBox3.Controls.Add(this.lblErrorMsg);
            this.groupBox3.Controls.Add(this.dgvTables);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(443, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(523, 529);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Availbale Tables";
            // 
            // btnFindAvailableTables
            // 
            this.btnFindAvailableTables.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAvailableTables.Location = new System.Drawing.Point(16, 37);
            this.btnFindAvailableTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAvailableTables.Name = "btnFindAvailableTables";
            this.btnFindAvailableTables.Size = new System.Drawing.Size(487, 37);
            this.btnFindAvailableTables.TabIndex = 5;
            this.btnFindAvailableTables.Text = "Find Available Tables";
            this.btnFindAvailableTables.UseVisualStyleBackColor = true;
            this.btnFindAvailableTables.Click += new System.EventHandler(this.BtnFindAvailableTables_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(16, 80);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(487, 431);
            this.lblErrorMsg.TabIndex = 18;
            this.lblErrorMsg.Text = "No availability matches your selected criteria.";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // dgvTables
            // 
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableId,
            this.TableNo,
            this.Capacity,
            this.Location});
            this.dgvTables.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTables.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTables.EnableHeadersVisualStyles = false;
            this.dgvTables.Location = new System.Drawing.Point(16, 91);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTables.RowHeadersVisible = false;
            this.dgvTables.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvTables.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size = new System.Drawing.Size(487, 420);
            this.dgvTables.TabIndex = 17;
            this.dgvTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTables_CellContentClick);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNo.DefaultCellStyle = dataGridViewCellStyle3;
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
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.tbTableCapacity);
            this.grpReservationDetails.Controls.Add(this.lblTableCapacity);
            this.grpReservationDetails.Controls.Add(this.cmbStatus);
            this.grpReservationDetails.Controls.Add(this.lblStatus);
            this.grpReservationDetails.Controls.Add(this.tbTableNo);
            this.grpReservationDetails.Controls.Add(this.lblTableText);
            this.grpReservationDetails.Controls.Add(this.lblTime);
            this.grpReservationDetails.Controls.Add(this.timePicker);
            this.grpReservationDetails.Controls.Add(this.lblDate);
            this.grpReservationDetails.Controls.Add(this.datePicker);
            this.grpReservationDetails.Controls.Add(this.lblNumOfGuests);
            this.grpReservationDetails.Controls.Add(this.numericNumOfGuests);
            this.grpReservationDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReservationDetails.Location = new System.Drawing.Point(45, 258);
            this.grpReservationDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReservationDetails.Size = new System.Drawing.Size(365, 358);
            this.grpReservationDetails.TabIndex = 25;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // tbTableCapacity
            // 
            this.tbTableCapacity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableCapacity.Location = new System.Drawing.Point(205, 256);
            this.tbTableCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTableCapacity.Name = "tbTableCapacity";
            this.tbTableCapacity.ReadOnly = true;
            this.tbTableCapacity.Size = new System.Drawing.Size(139, 30);
            this.tbTableCapacity.TabIndex = 23;
            // 
            // lblTableCapacity
            // 
            this.lblTableCapacity.AutoSize = true;
            this.lblTableCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableCapacity.Location = new System.Drawing.Point(11, 254);
            this.lblTableCapacity.Name = "lblTableCapacity";
            this.lblTableCapacity.Size = new System.Drawing.Size(141, 28);
            this.lblTableCapacity.TabIndex = 22;
            this.lblTableCapacity.Text = "Table Capacity:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(205, 301);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(143, 31);
            this.cmbStatus.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(11, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 28);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Reseravtion Status:";
            // 
            // tbTableNo
            // 
            this.tbTableNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTableNo.Location = new System.Drawing.Point(205, 203);
            this.tbTableNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(205, 49);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(143, 30);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfGuests.Location = new System.Drawing.Point(11, 153);
            this.lblNumOfGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(174, 28);
            this.lblNumOfGuests.TabIndex = 4;
            this.lblNumOfGuests.Text = "Number of Guests:";
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
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.tbPhoneNumber);
            this.grpCustomerInfo.Controls.Add(this.tbCustName);
            this.grpCustomerInfo.Controls.Add(this.lblPhoneNum);
            this.grpCustomerInfo.Controls.Add(this.lblCustName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(45, 87);
            this.grpCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomerInfo.Size = new System.Drawing.Size(365, 146);
            this.grpCustomerInfo.TabIndex = 24;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Details";
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
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(167, 39);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustName.MaxLength = 25;
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(177, 34);
            this.tbCustName.TabIndex = 10;
            this.tbCustName.TextChanged += new System.EventHandler(this.tbCustName_TextChanged);
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
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.Location = new System.Drawing.Point(153, 651);
            this.btnUpdateReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(257, 48);
            this.btnUpdateReservation.TabIndex = 23;
            this.btnUpdateReservation.Text = "Update Reservation";
            this.btnUpdateReservation.UseVisualStyleBackColor = true;
            this.btnUpdateReservation.Click += new System.EventHandler(this.BtnUpdateReservation_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(323, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 38);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Reservation Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(459, 651);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 48);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 28;
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
            // FrmUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 762);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUpdateReservation";
            this.Text = "Update Reservation";
            this.Load += new System.EventHandler(this.UpdateReservationForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfGuests)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFindAvailableTables;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.NumericUpDown numericNumOfGuests;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTableText;
        private System.Windows.Forms.TextBox tbTableNo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.TextBox tbTableCapacity;
        private System.Windows.Forms.Label lblTableCapacity;
    }
}