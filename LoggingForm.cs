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

        private void btnManager_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Manager";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Show();
            menu.Show();
            this.Hide();


        }

        private void btnWaiter_Click(object sender, EventArgs e)
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

            StyleRoleButton(btnManager, Color.FromArgb(0, 120, 215), "Manager Access");
            StyleRoleButton(btnWaiter, Color.FromArgb(72, 187, 120), "Staff / Waiter");

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

        private void StyleRoleButton(Button btn, Color accentColor, string subText)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.ForeColor = accentColor;
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.Text = $"{subText}";


            btn.Height = 140;
            btn.Width = 250;

            btn.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btn.FlatAppearance.BorderSize = 1;

            btn.Text = btn.Text.ToUpper();

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = accentColor;
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.White;
                btn.ForeColor = accentColor;
            };
        }



        private void FrmLogging_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this page?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }
    }
}
