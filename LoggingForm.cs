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

        private void button1_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Manager";

            FrmMainMenu menu = new FrmMainMenu();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogging_Load(object sender, EventArgs e)
        {

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
    }
}
