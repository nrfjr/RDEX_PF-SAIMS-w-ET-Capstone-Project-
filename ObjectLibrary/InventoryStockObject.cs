using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class InventoryStockObject
    {
        public int Inventory_Id { get; set; }
        public string Reference_Number { get; set; }
        public double Quantity { get; set; }
        public int Restock_Point { get; set; }
        public DateTime Entry_Date { get; set; }
        public string Status { get; set; }
        public int Item_Id { get; set; }
        public int FType_Id { get; set; }
        public int Unit_Id { get; set; }
        public int Supplier_Id { get; set; }
        public int Production_Id { get; set; }
        public string Search { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
    }
}
