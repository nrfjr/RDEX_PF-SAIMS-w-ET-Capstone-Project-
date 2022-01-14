using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Datasets
{
    public class OrderSlip
    {
        public OrderSlip(string cus, string add, string qty,  string unit,  string abw, string total, string  osnum, string price)
        {
            this.Customer = cus;
            this.Address = add;
            this.Order_Qty = qty;
            this.Unit = unit;
            this.ABW = abw;
            this.TotalSales = total;
            this.OS_Number = osnum;
            this.Price = price;

        }
        public string ABW { get; set; }
        public string OS_Number { get; set; }
        public string Order_Qty { get; set; }
        public string Price { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public string Unit { get; set; }
        public string TotalSales { get; set; }
    }
}
