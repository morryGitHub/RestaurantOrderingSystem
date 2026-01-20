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
    public partial class frmLogging : Form
    {
        public frmLogging()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Manager";

            frmMainMenu menu = new frmMainMenu();
            menu.FormClosed += (s, args) => this.Close(); 
            menu.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.UserType = "Waiter";

            frmMainMenu menu = new frmMainMenu();
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
    }
}
