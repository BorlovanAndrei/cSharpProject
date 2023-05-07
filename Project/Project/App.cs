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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void shopToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.MdiParent= this;
            login.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount newAccount = new CreateAccount();
            newAccount.MdiParent = this;
            newAccount.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateShop newShop = new CreateShop();
            newShop.MdiParent = this;
            newShop.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDepartment newDepartment = new CreateDepartment();
            newDepartment.MdiParent = this;
            newDepartment.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSale newSale = new CreateSale();
            newSale.MdiParent = this;
            newSale.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
