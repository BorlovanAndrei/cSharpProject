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

        private readonly BindingList<Shop> _shop;
        public string ShopName { get; set; }
        public int ShopId { get; set; }
        public string location { get; set; }
        public string phoneNo { get; set; }

        public CreateShop()
        {
            InitializeComponent();
            _shop = new BindingList<Shop>();
            tbShopId.Text = "";
        }

        //public void displayShop()
        //{
        //    lvShop.Items.Clear();

        //    foreach(Shop shop in _shop)
        //    {
        //        var listViewItem = new ListViewItem(shop.shopName);
        //        listViewItem.SubItems.Add($"{shop.shopId}");
        //        listViewItem.SubItems.Add(shop.location);
        //        listViewItem.SubItems.Add(shop.phoneNo);

        //        lvShop.Items.Add(listViewItem);
        //    }
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string shopname = tbShopName.Text;
            //int shopid = int.Parse(tbShopId.Text);
            //string location = tbLocation.Text;
            //string phnumber = tbPhoneNumber.Text;

            var shop = new Shop(ShopName,ShopId ,location, phoneNo);
            _shop.Add(shop);
            //displayShop();
        }

        private void CreateShop_Load(object sender, EventArgs e)
        {
            dgvShop.DataSource = _shop;
            //tbShopId.Text = null;

            tbShopName.DataBindings.Add("Text", this, "ShopName");
            tbShopId.DataBindings.Add("Text", this, "ShopId");
            tbLocation.DataBindings.Add("Text", this, "location");
            tbPhoneNumber.DataBindings.Add("Text", this, "phoneNo");
           
        }

        private void dgvShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
