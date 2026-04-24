using Oracle.ManagedDataAccess.Client;
using RestaurantOrderingSystem.OracleDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderingSystem
{
    public partial class FrmLogging : Form
    {
        public FrmLogging()
        {
            InitializeComponent();
        }

        private void BtnManager_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Manager";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Show();
            menu.Show();
            this.Hide();


        }

        private void BtnWaiter_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Waiter";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Show();
            menu.Show();
            this.Hide();


        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void FrmLogging_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblRestaurantName.ForeColor = Color.FromArgb(30, 41, 59);
            lblRestaurantName.TextAlign = ContentAlignment.MiddleCenter;

            StyleManagerButton(btnManager, "Manager Access");
            StyleWaiterButton(btnWaiter, "Staff / Waiter");

            lblClock.Font = new Font("Segoe UI Semibold", 12, FontStyle.Regular);
            lblClock.ForeColor = Color.FromArgb(120, 120, 120);
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

            lblStatus.Font = new Font("Segoe UI Semibold", 12, FontStyle.Italic);

            if (!Database.IsDatabaseAvailable())
            {
                lblStatus.Text = "Status: Database Offline";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Status: Database Online";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void StyleManagerButton(Button btn, string subText)
        {
            btn.Size = new Size(250, 140);
            btn.Text = subText.ToUpper();
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;

            Color managerBlue = Color.FromArgb(0, 120, 215);
            btn.BackColor = Color.White;
            btn.ForeColor = managerBlue;

            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 225, 240);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 200, 220);
        }

        private void StyleWaiterButton(Button btn, string subText)
        {
            btn.Size = new Size(250, 140);
            btn.Text = subText.ToUpper();
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;

            Color waiterGreen = Color.FromArgb(72, 187, 120);
            btn.BackColor = Color.White;
            btn.ForeColor = waiterGreen;

            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 235, 220);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 220, 200);
        }

 

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

        }
    }
}
