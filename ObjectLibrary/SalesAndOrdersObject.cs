using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class SalesAndOrdersObject
    {
        public int Order_Id { get; set; }
        public int Production_Id { get; set; }
        public string Price_Code { get; set; }
        public int Customer_Id { get; set; }
        public long Order_Qty { get; set; }
        public long Order_Slip_Number { get; set; }
        public string Order_Status { get; set; }
        public DateTime Entry_Date { get; set; }
        public string Order_Remarks { get; set; }
        public Double Sales_Amount { get; set; }
        public string Search { get; set; }


    }
}
