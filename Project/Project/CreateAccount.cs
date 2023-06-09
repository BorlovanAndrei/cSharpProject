﻿using Project.Classes;
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
        #region Attributes

        private readonly List<Manager> _manager;
        private string connectionStringCreateAcc = "Data source=database.db";
        #endregion

        public CreateAccount()
        {
            InitializeComponent();
            _manager = new List<Manager>();
        }



        #region Methods
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

                listViewItem.Tag= manager;

                lvManager.Items.Add(listViewItem);
            }
        }

        private void LoadManager()
        {
            string query = "SELECT * FROM createaccount";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string email = (string)reader["Email"];
                        string phoneNumber = (string)reader["PhoneNumber"];
                        long shopId = (long)reader["ShopId"];
                        string username = (string)reader["Username"];
                        string password = (string)reader["Password"];
                        Manager manager = new Manager(id, firstName, lastName, email, phoneNumber, shopId, username,password);
                        _manager.Add(manager);
                    }
                }
            }
        }
        private void AddManager(Manager manager)
        {
            //string query = "INSERT INTO createaccount(FirstName, LastName, Email, PhoneNumber, ShopId, Username, Password) VALUES " +
            //    "('" + manager.firstName + "', '" + manager.lastName + "', '" + manager.email + "', '" +
            //    manager.phone + "', '" + manager.shopId + "', '" + manager.username + "', '" + manager.password + "'); SELECT last_insert_rowid()";
            //using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            //{
            //    SQLiteCommand command = new SQLiteCommand(query, connection);
            //    connection.Open();

            //    long id = (long)command.ExecuteScalar();
            //    manager.managerId = id;
            //    _manager.Add(manager);
            //}



            string query = "INSERT INTO createaccount (FirstName, LastName, Email, PhoneNumber, ShopId, Username, Password) " +
                           "VALUES (@firstName, @lastName, @email, @phoneNumber, @shopId, @username, @password); SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", manager.firstName);
                command.Parameters.AddWithValue("@lastName", manager.lastName);
                command.Parameters.AddWithValue("@email", manager.email);
                command.Parameters.AddWithValue("@phoneNumber", manager.phone);
                command.Parameters.AddWithValue("@shopId", manager.shopId);
                command.Parameters.AddWithValue("@username", manager.username);
                command.Parameters.AddWithValue("@password", manager.password);
                connection.Open();
                
                long id = (long)command.ExecuteScalar();
                manager.managerId= id;
                _manager.Add(manager);
            }

        }
        private void UpdateManager(Manager manager)
        {
            string query = "UPDATE createaccount SET FirstName=@firstName, LastName=@lastName, Email=@email, PhoneNumber=@phoneNumber, ShopId=@shopId, Username=@username, Password=@password WHERE Id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", manager.managerId);
                command.Parameters.AddWithValue("@firstName", manager.firstName);
                command.Parameters.AddWithValue("@lastName", manager.lastName);
                command.Parameters.AddWithValue("@email", manager.email);
                command.Parameters.AddWithValue("@phoneNumber", manager.phone);
                command.Parameters.AddWithValue("@shopId", manager.shopId);
                command.Parameters.AddWithValue("@username", manager.username);
                command.Parameters.AddWithValue("@password", manager.password);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
        private void DeleteManager(Manager manager)
        {
            string query = "DELETE FROM createaccount WHERE Id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateAcc))
            {
                SQLiteCommand command= new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", manager.managerId);

                connection.Open();
                command.ExecuteNonQuery();

                _manager.Remove(manager);
            }
        }

        #endregion


        #region Events
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
            if(lvManager.SelectedItems.Count > 0)
            {
                button2.Enabled= true;
            }
            else
            {
                button2.Enabled= false;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your given name.";
        }

        private void tbFirstName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbLastName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your family name.";
        }

        private void tbLastName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbEmail_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your e-mail.";
        }

        private void tbEmail_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your phone number.";
        }

        private void tbPhone_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbShopId_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the shop id you manage.";
        }

        private void tbShopId_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbUsername_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your username.";
        }

        private void tbUsername_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter your password.";
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to create account.";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(lvManager.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lvManager.SelectedItems[0];
            //    int index = lvManager.Items.IndexOf(selectedItem);
            //    if(index >=0 && index < _manager.Count)
            //    {
            //        _manager.RemoveAt(index);
            //        lvManager.Items.Remove(selectedItem);
            //    }
            //}

            if(lvManager.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a participant!");
            }else if(MessageBox.Show("Are you sure?", "Delete Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem selected = lvManager.SelectedItems[0];
                Manager manager = (Manager) selected.Tag;

                DeleteManager(manager);
                displayManager();
            }
        }

        private void update()
        {
            lvManager.SelectedItems[0].SubItems[0].Text = tbFirstName.Text;
            lvManager.SelectedItems[0].SubItems[1].Text = tbLastName.Text;
            lvManager.SelectedItems[0].SubItems[2].Text = tbEmail.Text;
            lvManager.SelectedItems[0].SubItems[3].Text = tbPhone.Text;
            lvManager.SelectedItems[0].SubItems[4].Text = tbShopId.Text;
            lvManager.SelectedItems[0].SubItems[5].Text = tbUsername.Text;
            lvManager.SelectedItems[0].SubItems[6].Text = tbPassword.Text;

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbShopId.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update();
            Manager selectedManager = (Manager)lvManager.SelectedItems[0].Tag;
            selectedManager.firstName = tbFirstName.Text;
            selectedManager.lastName = tbLastName.Text;
            selectedManager.email = tbEmail.Text;
            selectedManager.phone = tbPhone.Text;
            selectedManager.shopId = int.Parse(tbShopId.Text);
            selectedManager.username = tbUsername.Text;
            selectedManager.password = tbPassword.Text;

            UpdateManager(selectedManager);
            displayManager();
        }

        private void lvManager_Click(object sender, EventArgs e)
        {

        }

        private void lvManager_MouseClick(object sender, MouseEventArgs e)
        {
            //tbFirstName.Text =  lvManager.SelectedItems[0].SubItems[0].Text;
            //tbLastName.Text  = lvManager.SelectedItems[0].SubItems[1].Text;
            //tbEmail.Text =  lvManager.SelectedItems[0].SubItems[2].Text;
            //tbPhone.Text = lvManager.SelectedItems[0].SubItems[3].Text;
            //tbShopId.Text =  lvManager.SelectedItems[0].SubItems[4].Text;
            //tbUsername.Text  = lvManager.SelectedItems[0].SubItems[5].Text;
            //tbPassword.Text  = lvManager.SelectedItems[0].SubItems[6].Text;

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadManager();
            displayManager();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
