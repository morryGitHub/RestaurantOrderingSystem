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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResID = new System.Windows.Forms.Label();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbResID = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbGuests = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(205, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(351, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "--- Reservation Details ---";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(31, 202);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 247);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(31, 298);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(49, 16);
            this.lblGuests.TabIndex = 4;
            this.lblGuests.Text = "Guests";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 351);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblResID
            // 
            this.lblResID.AutoSize = true;
            this.lblResID.Location = new System.Drawing.Point(33, 121);
            this.lblResID.Name = "lblResID";
            this.lblResID.Size = new System.Drawing.Size(99, 16);
            this.lblResID.TabIndex = 6;
            this.lblResID.Text = "Reservation ID:";
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(36, 449);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(267, 31);
            this.btnCancelReservation.TabIndex = 7;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(267, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbResID
            // 
            this.tbResID.Location = new System.Drawing.Point(174, 119);
            this.tbResID.Name = "tbResID";
            this.tbResID.Size = new System.Drawing.Size(139, 22);
            this.tbResID.TabIndex = 9;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(174, 202);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(139, 22);
            this.tbPhone.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 165);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(139, 22);
            this.tbName.TabIndex = 11;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(174, 247);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(139, 22);
            this.tbDate.TabIndex = 12;
            // 
            // tbGuests
            // 
            this.tbGuests.Location = new System.Drawing.Point(174, 298);
            this.tbGuests.Name = "tbGuests";
            this.tbGuests.Size = new System.Drawing.Size(139, 22);
            this.tbGuests.TabIndex = 13;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(174, 351);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(139, 22);
            this.tbStatus.TabIndex = 14;
            // 
            // FrmCancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 631);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbGuests);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbResID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.lblResID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmCancelReservation";
            this.Text = "Cancel Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResID;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbResID;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbGuests;
        private System.Windows.Forms.TextBox tbStatus;
    }
}