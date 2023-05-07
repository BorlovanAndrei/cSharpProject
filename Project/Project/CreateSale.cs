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
        private void lvSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSale.SelectedItems.Count > 0)
            {
                button2.Enabled= true;
                //tbSaleId.Text = lvSale.SelectedItems[0].SubItems[0].Text;
                //tbItemName.Text = lvSale.SelectedItems[0].SubItems[1].Text;
                //tbNoItems.Text = lvSale.SelectedItems[0].SubItems[2].Text;
                //tbPrice.Text = lvSale.SelectedItems[0].SubItems[3].Text;
                //tbShopIdSale.Text = lvSale.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                button2.Enabled= false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(lvSale.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSale.SelectedItems[0];
                int index = lvSale.Items.IndexOf(selectedItem);
                if(index >= 0 && index < _sale.Count)
                {
                    _sale.RemoveAt(index);
                    lvSale.Items.Remove(selectedItem);
                }
            }
        }
        private void update()
        {
            lvSale.SelectedItems[0].SubItems[0].Text = tbSaleId.Text;
            lvSale.SelectedItems[0].SubItems[1].Text = tbItemName.Text;
            lvSale.SelectedItems[0].SubItems[2].Text = tbNoItems.Text;
            lvSale.SelectedItems[0].SubItems[3].Text = tbPrice.Text;
            lvSale.SelectedItems[0].SubItems[4].Text = tbShopIdSale.Text;

            tbSaleId.Text = "";
            tbItemName.Text = "";
            tbNoItems.Text = "";
            tbPrice.Text = "";
            tbShopIdSale.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            update();

        }

        private void lvSale_MouseClick(object sender, MouseEventArgs e)
        {
            tbSaleId.Text = lvSale.SelectedItems[0].SubItems[0].Text;
            tbItemName.Text = lvSale.SelectedItems[0].SubItems[1].Text;
            tbNoItems.Text = lvSale.SelectedItems[0].SubItems[2].Text;
            tbPrice.Text = lvSale.SelectedItems[0].SubItems[3].Text;
            tbShopIdSale.Text = lvSale.SelectedItems[0].SubItems[4].Text;
        }
    }



}
