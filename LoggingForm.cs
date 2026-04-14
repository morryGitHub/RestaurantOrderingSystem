using Oracle.ManagedDataAccess.Client;
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Manager";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
            this.Hide();


        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Waiter";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
            this.Hide();


        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void FrmLogging_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.Height = 80;

            StylePrimaryButton(btnManager);
            StyleSecondaryButton(btnWaiter);

   
        }

        private void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(0, 120, 215);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Height = 45;
            btn.Width = 220;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(0, 100, 180);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Height = 45;
            btn.Width = 220;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.Gray;
            btn.MouseLeave += (s, e) => btn.BackColor = Color.LightGray;
        }


    }
    
}
