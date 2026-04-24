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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.dgvMatchingReservation = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbCustName = new System.Windows.Forms.RadioButton();
            this.rbPhoneNum = new System.Windows.Forms.RadioButton();
            this.grpSearching = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResInfo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingReservation)).BeginInit();
            this.grpSearching.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(379, 25);
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
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(211, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustName.Location = new System.Drawing.Point(219, 41);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(161, 30);
            this.tbCustName.TabIndex = 7;
            this.tbCustName.Click += new System.EventHandler(this.TbCustName_Click);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.Location = new System.Drawing.Point(219, 100);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(161, 30);
            this.tbPhoneNum.TabIndex = 8;
            this.tbPhoneNum.Click += new System.EventHandler(this.TbPhoneNum_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Guests,
            this.TableNo,
            this.TableId,
            this.ResID});
            this.dgvMatchingReservation.EnableHeadersVisualStyles = false;
            this.dgvMatchingReservation.Location = new System.Drawing.Point(5, 37);
            this.dgvMatchingReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatchingReservation.MultiSelect = false;
            this.dgvMatchingReservation.Name = "dgvMatchingReservation";
            this.dgvMatchingReservation.ReadOnly = true;
            this.dgvMatchingReservation.RowHeadersVisible = false;
            this.dgvMatchingReservation.RowHeadersWidth = 51;
            this.dgvMatchingReservation.RowTemplate.Height = 24;
            this.dgvMatchingReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchingReservation.Size = new System.Drawing.Size(841, 146);
            this.dgvMatchingReservation.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.FillWeight = 118.3155F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Phone.DefaultCellStyle = dataGridViewCellStyle3;
            this.Phone.FillWeight = 118.3155F;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Date.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date.FillWeight = 118.3155F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Guests
            // 
            this.Guests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Guests.DefaultCellStyle = dataGridViewCellStyle5;
            this.Guests.FillWeight = 60F;
            this.Guests.HeaderText = "Guests";
            this.Guests.MinimumWidth = 6;
            this.Guests.Name = "Guests";
            this.Guests.ReadOnly = true;
            this.Guests.Width = 114;
            // 
            // TableNo
            // 
            this.TableNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TableNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.TableNo.FillWeight = 60F;
            this.TableNo.HeaderText = "TableNo";
            this.TableNo.MinimumWidth = 4;
            this.TableNo.Name = "TableNo";
            this.TableNo.ReadOnly = true;
            this.TableNo.Width = 131;
            // 
            // TableId
            // 
            this.TableId.HeaderText = "TableId";
            this.TableId.MinimumWidth = 6;
            this.TableId.Name = "TableId";
            this.TableId.ReadOnly = true;
            this.TableId.Visible = false;
            // 
            // ResID
            // 
            this.ResID.HeaderText = "ResId";
            this.ResID.MinimumWidth = 6;
            this.ResID.Name = "ResID";
            this.ResID.ReadOnly = true;
            this.ResID.Visible = false;
            // 
            // rbCustName
            // 
            this.rbCustName.AutoSize = true;
            this.rbCustName.Checked = true;
            this.rbCustName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustName.Location = new System.Drawing.Point(19, 42);
            this.rbCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCustName.Name = "rbCustName";
            this.rbCustName.Size = new System.Drawing.Size(125, 32);
            this.rbCustName.TabIndex = 9;
            this.rbCustName.TabStop = true;
            this.rbCustName.Text = "Full Name:";
            this.rbCustName.UseVisualStyleBackColor = true;
            this.rbCustName.CheckedChanged += new System.EventHandler(this.RbCustName_CheckedChanged_1);
            // 
            // rbPhoneNum
            // 
            this.rbPhoneNum.AutoSize = true;
            this.rbPhoneNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPhoneNum.Location = new System.Drawing.Point(19, 101);
            this.rbPhoneNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPhoneNum.Name = "rbPhoneNum";
            this.rbPhoneNum.Size = new System.Drawing.Size(169, 32);
            this.rbPhoneNum.TabIndex = 10;
            this.rbPhoneNum.Text = "Phone Number:";
            this.rbPhoneNum.UseVisualStyleBackColor = true;
            this.rbPhoneNum.CheckedChanged += new System.EventHandler(this.RbPhoneNum_CheckedChanged);
            // 
            // grpSearching
            // 
            this.grpSearching.Controls.Add(this.rbPhoneNum);
            this.grpSearching.Controls.Add(this.rbCustName);
            this.grpSearching.Controls.Add(this.tbPhoneNum);
            this.grpSearching.Controls.Add(this.tbCustName);
            this.grpSearching.Controls.Add(this.btnSearch);
            this.grpSearching.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearching.Location = new System.Drawing.Point(276, 92);
            this.grpSearching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearching.Name = "grpSearching";
            this.grpSearching.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearching.Size = new System.Drawing.Size(429, 202);
            this.grpSearching.TabIndex = 12;
            this.grpSearching.TabStop = false;
            this.grpSearching.Text = "Search By:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResInfo);
            this.groupBox2.Controls.Add(this.dgvMatchingReservation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(852, 190);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matching Reservation";
            // 
            // lblResInfo
            // 
            this.lblResInfo.ForeColor = System.Drawing.Color.Red;
            this.lblResInfo.Location = new System.Drawing.Point(5, 37);
            this.lblResInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResInfo.Name = "lblResInfo";
            this.lblResInfo.Size = new System.Drawing.Size(841, 146);
            this.lblResInfo.TabIndex = 5;
            this.lblResInfo.Text = "No reservations were found matching your criteria.";
            this.lblResInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(575, 550);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 39);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(180, 550);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 39);
            this.btnNext.TabIndex = 22;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 28);
            this.menuStrip1.TabIndex = 24;
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
            // FrmFindReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 631);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpSearching);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFindReservation";
            this.Text = "Find Reservation";
            this.Load += new System.EventHandler(this.FrmFindReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchingReservation)).EndInit();
            this.grpSearching.ResumeLayout(false);
            this.grpSearching.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSearching;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label lblResInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guests;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResID;
    }
}