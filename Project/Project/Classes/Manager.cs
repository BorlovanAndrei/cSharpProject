using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class Manager
    {
        public long managerId { get; set; }
        public int shopId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Shop shop { get; set; }

        public Manager(string firstName, string lastName, string email, string phone, int shopId, string username, string pass)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.shopId = shopId;
            this.username = username;
            this.password = pass;
        }
        public Manager()
        {
            this.managerId = -1;
            this.shopId = -1;
            this.shop = null;
            this.firstName = "No first name for manager ";
            this.lastName = "No last name for manager ";
            this.email = "No email for manager ";
            this.phone = "No phone number for manager ";
        }

        public Manager(int managerId, int shopId, string firstName, string lastName, string email, string phone, Shop shop)
        {
            this.managerId = managerId;
            this.shopId = shopId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.shop = shop;
        }

    }
}
