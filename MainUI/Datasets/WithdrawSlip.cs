using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Datasets
{
    public class WithdrawSlip
    {
        public WithdrawSlip(string qty, string item, string type, string unit, string pnum, string cat)
        {
            this.Qty = qty;
            this.ItemName = item;
            this.FeedType = type;
            this.Unit = unit;
            this.ProductionNo = pnum;
            this.Category = cat;

        }
        public string Qty { get; set; }
        public string ItemName { get; set; }
        public string FeedType { get; set; }
        public string Unit { get; set; }
        public string ProductionNo { get; set; }
        public string Category { get; set; }
    }
}
