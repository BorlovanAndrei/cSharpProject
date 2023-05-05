using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    internal class Sale
    {
        public int saleId { get; set; }
        public int noSales { get; set; }
        public int shopId { get; set; }

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
