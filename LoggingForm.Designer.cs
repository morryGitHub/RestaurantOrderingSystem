namespace RestaurantOrderingSystem
{
    partial class FrmLogging
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnWaiter = new System.Windows.Forms.Button();
            this.labelFooter = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 0;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManager.Location = new System.Drawing.Point(184, 241);
            this.btnManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(333, 148);
            this.btnManager.TabIndex = 2;
            this.btnManager.TabStop = false;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.BtnManager_Click);
            // 
            // btnWaiter
            // 
            this.btnWaiter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnWaiter.Location = new System.Drawing.Point(741, 241);
            this.btnWaiter.Margin = new System.Windows.Forms.Padding(4);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Size = new System.Drawing.Size(333, 148);
            this.btnWaiter.TabIndex = 3;
            this.btnWaiter.TabStop = false;
            this.btnWaiter.Text = "Waiter";
            this.btnWaiter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWaiter.UseVisualStyleBackColor = true; 
            this.btnWaiter.Click += new System.EventHandler(this.BtnWaiter_Click);

            // 
            // labelFooter
            // 
            this.labelFooter.Location = new System.Drawing.Point(0, 0);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(100, 23);
            this.labelFooter.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(1129, 532);
            this.lblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(62, 25);
            this.lblClock.TabIndex = 6;
            this.lblClock.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(55, 532);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 25);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "DB status";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(13, 88);
            this.lblRestaurantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(1230, 62);
            this.lblRestaurantName.TabIndex = 8;
            this.lblRestaurantName.Text = "THE MORRY RESTAURANT";
            this.lblRestaurantName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 593);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnWaiter);
            this.Controls.Add(this.btnManager);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogging";
            this.Text = "Restaurant System - Login";
            this.Load += new System.EventHandler(this.FrmLogging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnWaiter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRestaurantName;
    }
}

