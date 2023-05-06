using Project.Classes;
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
    public partial class CreateShop : Form
    {

        private readonly List<Shop> _shop;

        public CreateShop()
        {
            InitializeComponent();
            _shop = new List<Shop>();
        }

        public void displayShop()
        {
            lvShop.Items.Clear();

            foreach(Shop shop in _shop)
            {
                var listViewItem = new ListViewItem(shop.shopName);
                listViewItem.SubItems.Add($"{shop.shopId}");
                listViewItem.SubItems.Add(shop.location);
                listViewItem.SubItems.Add(shop.phoneNo);

                lvShop.Items.Add(listViewItem);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string shopname = tbShopName.Text;
            int shopid = int.Parse(tbShopId.Text);
            string location = tbLocation.Text;
            string phnumber = tbPhoneNumber.Text;

            var shop = new Shop(shopname, shopid, location, phnumber);
            _shop.Add(shop);
            displayShop();
        }
    }
}
