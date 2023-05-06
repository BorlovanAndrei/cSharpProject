using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LogIn : Form
    {
        //private string connectingString = "Data source = Database.db";


        public LogIn()
        {
            InitializeComponent();
        }

        private void addParticipant()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty || tbPassword.Text != string.Empty)
            {
                if(tbUsername.Text == "Admin" && tbPassword.Text == "Password")
                {
                    LoginMenu menu  = new LoginMenu();
                    menu.Show();
                }
                else
                {
                    throw new Exception("The username or password is incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }
    }
}
