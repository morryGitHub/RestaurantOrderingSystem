namespace RestaurantOrderingSystem
{
    partial class FrmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprintReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printYearlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.findReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem,
            this.updateReservationToolStripMenuItem,
            this.removeReservationToolStripMenuItem,
            this.findReservationToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reservationToolStripMenuItem.Text = "Reservations";
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addReservationToolStripMenuItem.Text = "Add Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.AddReservationToolStripMenuItem_Click);
            // 
            // updateReservationToolStripMenuItem
            // 
            this.updateReservationToolStripMenuItem.Name = "updateReservationToolStripMenuItem";
            this.updateReservationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateReservationToolStripMenuItem.Text = "Update Reservation";
            this.updateReservationToolStripMenuItem.Click += new System.EventHandler(this.UpdateReservationToolStripMenuItem_Click);
            // 
            // removeReservationToolStripMenuItem
            // 
            this.removeReservationToolStripMenuItem.Name = "removeReservationToolStripMenuItem";
            this.removeReservationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeReservationToolStripMenuItem.Text = "Remove Reservation";
            this.removeReservationToolStripMenuItem.Click += new System.EventHandler(this.RemoveReservationToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.updateTableToolStripMenuItem,
            this.removeTableToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addTableToolStripMenuItem.Text = "Add Table";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.AddTableToolStripMenuItem_Click);
            // 
            // updateTableToolStripMenuItem
            // 
            this.updateTableToolStripMenuItem.Name = "updateTableToolStripMenuItem";
            this.updateTableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateTableToolStripMenuItem.Text = "Update Table";
            this.updateTableToolStripMenuItem.Click += new System.EventHandler(this.UpdateTableToolStripMenuItem_Click);
            // 
            // removeTableToolStripMenuItem
            // 
            this.removeTableToolStripMenuItem.Name = "removeTableToolStripMenuItem";
            this.removeTableToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeTableToolStripMenuItem.Text = "Remove Table";
            this.removeTableToolStripMenuItem.Click += new System.EventHandler(this.RemoveTableToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.updateExistingOrderToolStripMenuItem,
            this.cancelOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addOrderToolStripMenuItem.Text = "Create New Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.AddOrderToolStripMenuItem_Click);
            // 
            // updateExistingOrderToolStripMenuItem
            // 
            this.updateExistingOrderToolStripMenuItem.Name = "updateExistingOrderToolStripMenuItem";
            this.updateExistingOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.updateExistingOrderToolStripMenuItem.Text = "Update Existing Order";
            this.updateExistingOrderToolStripMenuItem.Click += new System.EventHandler(this.UpdateExistingOrderToolStripMenuItem_Click);
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cancelOrderToolStripMenuItem.Text = "Cancel Order";
            this.cancelOrderToolStripMenuItem.Click += new System.EventHandler(this.CancelOrderToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePaymentToolStripMenuItem,
            this.reprintToolStripMenuItem,
            this.reprintReceiptToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.MakePaymentToolStripMenuItem_Click);
            // 
            // reprintToolStripMenuItem
            // 
            this.reprintToolStripMenuItem.Name = "reprintToolStripMenuItem";
            this.reprintToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.reprintToolStripMenuItem.Text = "Refund Payment";
            this.reprintToolStripMenuItem.Click += new System.EventHandler(this.ReprintToolStripMenuItem_Click);
            // 
            // reprintReceiptToolStripMenuItem
            // 
            this.reprintReceiptToolStripMenuItem.Name = "reprintReceiptToolStripMenuItem";
            this.reprintReceiptToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.reprintReceiptToolStripMenuItem.Text = "Reprint Receipt";
            this.reprintReceiptToolStripMenuItem.Click += new System.EventHandler(this.ReprintReceiptToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printYearlyToolStripMenuItem,
            this.displayStatisticsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.statisticsToolStripMenuItem.Text = "Admin";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.StatisticsToolStripMenuItem_Click);
            // 
            // printYearlyToolStripMenuItem
            // 
            this.printYearlyToolStripMenuItem.Name = "printYearlyToolStripMenuItem";
            this.printYearlyToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.printYearlyToolStripMenuItem.Text = "Print Yearly Revenue Analysis";
            this.printYearlyToolStripMenuItem.Click += new System.EventHandler(this.PrintYearlyToolStripMenuItem_Click);
            // 
            // displayStatisticsToolStripMenuItem
            // 
            this.displayStatisticsToolStripMenuItem.Name = "displayStatisticsToolStripMenuItem";
            this.displayStatisticsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.displayStatisticsToolStripMenuItem.Text = "Display Statistics";
            this.displayStatisticsToolStripMenuItem.Click += new System.EventHandler(this.DisplayStatisticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(40, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RestaurantOrderingSystem.Properties.Resources.restaurantSystem;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // findReservationToolStripMenuItem
            // 
            this.findReservationToolStripMenuItem.Name = "findReservationToolStripMenuItem";
            this.findReservationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.findReservationToolStripMenuItem.Text = "Find Reservation";
            this.findReservationToolStripMenuItem.Click += new System.EventHandler(this.FindReservationToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprintReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printYearlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStatisticsToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReservationToolStripMenuItem;
    }
}