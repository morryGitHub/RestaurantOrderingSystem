namespace RestaurantOrderingSystem
{
    partial class FrmFindReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(284, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Find Reservation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(73, 122);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(164, 33);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(122, 26);
            this.tbCustName.TabIndex = 7;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.Location = new System.Drawing.Point(164, 81);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(122, 26);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchingReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatchingReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchingReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.Phone,
            this.Date,
            this.Guests,
            this.TableNo,
            this.TableID});
            this.dgvMatchingReservation.EnableHeadersVisualStyles = false;
            this.dgvMatchingReservation.Location = new System.Drawing.Point(4, 30);
            this.dgvMatchingReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMatchingReservation.MultiSelect = false;
            this.dgvMatchingReservation.Name = "dgvMatchingReservation";
            this.dgvMatchingReservation.ReadOnly = true;
            this.dgvMatchingReservation.RowHeadersVisible = false;
            this.dgvMatchingReservation.RowHeadersWidth = 51;
            this.dgvMatchingReservation.RowTemplate.Height = 24;
            this.dgvMatchingReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchingReservation.Size = new System.Drawing.Size(631, 119);
            this.dgvMatchingReservation.TabIndex = 4;
            this.dgvMatchingReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchingReservation_CellContentClick);
            // 
            // rbCustName
            // 
            this.rbCustName.AutoSize = true;
            this.rbCustName.Checked = true;
            this.rbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustName.Location = new System.Drawing.Point(14, 30);
            this.rbCustName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCustName.Name = "rbCustName";
            this.rbCustName.Size = new System.Drawing.Size(102, 25);
            this.rbCustName.TabIndex = 9;
            this.rbCustName.TabStop = true;
            this.rbCustName.Text = "Full Name:";
            this.rbCustName.UseVisualStyleBackColor = true;
            // 
            // rbPhoneNum
            // 
            this.rbPhoneNum.AutoSize = true;
            this.rbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoneNum.Location = new System.Drawing.Point(14, 78);
            this.rbPhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPhoneNum.Name = "rbPhoneNum";
            this.rbPhoneNum.Size = new System.Drawing.Size(137, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(207, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 164);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMatchingReservation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(639, 154);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matching Reservation";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(431, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewOrder.Location = new System.Drawing.Point(135, 447);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(139, 32);
            this.btnCreateNewOrder.TabIndex = 22;
            this.btnCreateNewOrder.Text = "Create Order";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCancelReservation_Click_1);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Guests
            // 
            this.Guests.HeaderText = "Guests";
            this.Guests.MinimumWidth = 6;
            this.Guests.Name = "Guests";
            this.Guests.ReadOnly = true;
            // 
            // TableNo
            // 
            this.TableNo.HeaderText = "TableNo";
            this.TableNo.MinimumWidth = 6;
            this.TableNo.Name = "TableNo";
            this.TableNo.ReadOnly = true;
            // 
            // TableID
            // 
            this.TableID.HeaderText = "TableID";
            this.TableID.Name = "TableID";
            this.TableID.ReadOnly = true;
            this.TableID.Visible = false;
            // 
            // FrmFindReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 513);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreateNewOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmFindReservation";
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
        private System.Windows.Forms.Button btnCreateNewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
    }
}