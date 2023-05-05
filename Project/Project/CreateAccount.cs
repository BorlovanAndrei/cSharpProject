using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CreateAccount : Form
    {
        private readonly List<Manager> _manager;
        
        public CreateAccount()
        {
            InitializeComponent();
            _manager = new List<Manager>();
        }

        public void displayManager()
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Manager manager = new Manager();
             string firstName = tbFirstName.Text;
             string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            int shopId = int.Parse(tbShopId.Text); 
            
            var manager = new Manager(firstName,lastName, email, phone, shopId);
            _manager.Add(manager);
            //displayManager();

        }
    }
}
