using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class Shop
    {
        public int shopId { get; set; }
        public string shopName { get; set; }
        public string location { get; set; }
        public string phoneNo { get; set; }

        public List<Department> departments { get; set; }
        public List<Sale> sales { get; set; }

        public Shop()
        {
            departments = new List<Department>();
            sales = new List<Sale>();
            this.shopId = -1;
            this.shopName = "No name for shop";
            this.location = "No location for this shop";
            this.phoneNo = "No phone number for this shop";
        }

        public Shop(int shopId, string shopName, List<Department> departments, List<Sale> sales, string location, string phoneNo)
        {
            this.shopId = shopId;
            this.shopName = shopName;
            this.departments = departments;
            this.sales = sales;
            this.location = location;
            this.phoneNo = phoneNo;
        }

    }
}
