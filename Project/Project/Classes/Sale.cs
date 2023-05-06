using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class Sale
    {
        public int saleId { get; set; }
        public int noSales { get; set; }
        public int shopId { get; set; }
        public string itemName { get; set; }
        public int price { get; set; }
        public int noItems { get; set; }
        public Sale(int saleId, string shopName, int noItems, int price, int shopId)
        {
            this.saleId = saleId;
            this.noItems = noItems;
            this.shopId = shopId;
            this.itemName = shopName;
            this.price = price;

        }

        public Sale()
        {
            this.saleId = -1;
            this.noSales = 0;
            this.shopId = -1;
        }

        public Sale(int saleId, int noSales, int shopId)
        {
            this.saleId = saleId;
            this.noSales = noSales;
            this.shopId = shopId;
        }
    }
}
