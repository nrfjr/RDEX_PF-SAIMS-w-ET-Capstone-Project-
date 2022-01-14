using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Datasets
{
    public class ReceivedSlip
    {
        public ReceivedSlip(string rnum, string item, string cat, string type, string qty, string unit)
        {
            this.ReferenceNo = rnum;
            this.ItemName = item;
            this.Category = cat;
            this.Type = type;
            this.Qty = qty;
            this.Unit = unit;

        }
        public string ReferenceNo { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Qty { get; set; }
        public string Unit { get; set; }
    }
}
