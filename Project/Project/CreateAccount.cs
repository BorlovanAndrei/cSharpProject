using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public partial class CreateAccount : Form
    {
        private readonly List<Manager> _manager;
        private string connectionStringCreateAcc = "Data source=database.db";
        
        public CreateAccount()
        {
            InitializeComponent();
            _manager = new List<Manager>();
        }




        public void displayManager()
        {
            lvManager.Items.Clear();

            foreach(Manager manager in _manager)
            {
                var listViewItem = new ListViewItem(manager.firstName);
                listViewItem.SubItems.Add(manager.lastName);
                listViewItem.SubItems.Add(manager.email);
                listViewItem.SubItems.Add(manager.phone);
                //listViewItem.SubItems.Add($"{manager.phone}");
                //listViewItem.SubItems.Add(manager.shopId);
                listViewItem.SubItems.Add($"{manager.shopId}");
                listViewItem.SubItems.Add(manager.username);
                listViewItem.SubItems.Add(manager.password);
                lvManager.Items.Add(listViewItem);
            }
        }

        private void AddManager(Manager manager)
        {
            string query = "INSERT INTO createaccount(FirstName, LastName, Email, PhoneNumber, ShopId, Username, Password) VALUES " +
                "('" + manager.firstName + "', '" + manager.lastName + "', '" + manager.email + "', '" +
                manager.phone + "', '" + manager.shopId + "', '" + manager.username + "', '" + manager.password + "'); SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();

                long id = (long)command.ExecuteScalar();
                manager.managerId = id;
                _manager.Add(manager);
            }



            //string query = "INSERT INTO createaccount (FirstName, LastName, Email, PhoneNumber, ShopId, Username, Password) " +
            //               "VALUES (@firstName, @lastName, @email, @phoneNumber, @shopId, @username, @password)";
            //using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            //{
            //    SQLiteCommand command = new SQLiteCommand(query, connection);
            //    command.Parameters.AddWithValue("@firstName", manager.firstName);
            //    command.Parameters.AddWithValue("@lastName", manager.lastName);
            //    command.Parameters.AddWithValue("@email", manager.email);
            //    command.Parameters.AddWithValue("@phoneNumber", manager.phone);
            //    command.Parameters.AddWithValue("@shopId", manager.shopId);
            //    command.Parameters.AddWithValue("@username", manager.username);
            //    command.Parameters.AddWithValue("@password", manager.password);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Manager manager = new Manager();
             string firstName = tbFirstName.Text;
             string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            int shopId = int.Parse(tbShopId.Text); 
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            
            var manager = new Manager(firstName,lastName, email, phone, shopId,username, password);
            //_manager.Add(manager);
            AddManager(manager);
            displayManager();


        }

        private void lvManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
