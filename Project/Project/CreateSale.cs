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
    public partial class CreateSale : Form
    {
        private readonly List<Sale> _sale;
        public CreateSale()
        {
            InitializeComponent();
            _sale = new List<Sale>();
        }
        public void displaySale()
        {
            lvSale.Items.Clear();
            foreach (Sale sale in _sale)
            {
                var listViewItem = new ListViewItem($"{sale.saleId}");
                listViewItem.SubItems.Add(sale.itemName);
                listViewItem.SubItems.Add($"{sale.noItems}");
                listViewItem.SubItems.Add($"{sale.price}");
                listViewItem.SubItems.Add($"{sale.shopId}");

                lvSale.Items.Add(listViewItem);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saleId = int.Parse(tbSaleId.Text);
            string itemName = tbItemName.Text;
            int noItems = int.Parse(tbNoItems.Text);
            int price  = int.Parse(tbPrice.Text);
            int shopId = int.Parse(tbShopIdSale.Text);
            var sale = new Sale(saleId,itemName,noItems,price,shopId);

            _sale.Add(sale);
            displaySale();
        }
    }
}
