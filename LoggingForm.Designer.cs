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
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(250, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Restaurant System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Location = new System.Drawing.Point(220, 180);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(500, 70);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnWaiter
            // 
            this.btnWaiter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnWaiter.ForeColor = System.Drawing.Color.White;
            this.btnWaiter.Location = new System.Drawing.Point(220, 292);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Size = new System.Drawing.Size(500, 70);
            this.btnWaiter.TabIndex = 2;
            this.btnWaiter.Text = "Waiter";
            this.btnWaiter.UseVisualStyleBackColor = false;
            this.btnWaiter.Click += new System.EventHandler(this.btnWaiter_Click);
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.Gray;
            this.labelFooter.Location = new System.Drawing.Point(351, 418);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(225, 28);
            this.labelFooter.TabIndex = 3;
            this.labelFooter.Text = "© 2025 Restaurant App";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnWaiter);
            this.Controls.Add(this.labelFooter);
            this.Name = "FrmLogging";
            this.Text = "Log In";
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

