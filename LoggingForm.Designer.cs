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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnWaiter = new System.Windows.Forms.Button();
            this.labelFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Food Ordering System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(370, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select your role";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManager.Location = new System.Drawing.Point(200, 221);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(140, 60);
            this.btnManager.TabIndex = 2;
            this.btnManager.TabStop = false;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnWaiter
            // 
            this.btnWaiter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnWaiter.Location = new System.Drawing.Point(566, 221);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Size = new System.Drawing.Size(140, 60);
            this.btnWaiter.TabIndex = 3;
            this.btnWaiter.TabStop = false;
            this.btnWaiter.Text = "Waiter";
            this.btnWaiter.UseVisualStyleBackColor = true;
            this.btnWaiter.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "                     © 2025 Restaurant App";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Full access to reservations, \r\ntables, and reports";
            // 
            // labelFooter
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(498, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = " Manage orders and customers";
            // 
            // FrmLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWaiter);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogging";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogging_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDesc1;
        private System.Windows.Forms.Label labelDesc2;
        private System.Windows.Forms.Button btnWaiter;
        private System.Windows.Forms.Label labelFooter;
    }
}

