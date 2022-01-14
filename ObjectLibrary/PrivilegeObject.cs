﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class PrivilegeObject
    {
        public int Role_Id { get; set; }
        public string Dashboard { get; set; }
        public string Customer { get; set; }
        public string Supplier { get; set; }
        public string Items { get; set; }
        public string Feeds_Type { get; set; }
        public string Expense_Type { get; set; }
        public string Ponds { get; set; }
        public string Pricing { get; set; }
        public string Pond_Plan_Entry { get; set; }
        public string Pond_Weekly_Updates { get; set; }
        public string Pond_Results { get; set; }
        public string Available_Stock { get; set; }
        public string Critical_Stock { get; set; }
        public string Material_Request { get; set; }
        public string Stock_Receiving { get; set; }
        public string Stock_Withdrawal { get; set; }
        public string Sales_Entry { get; set; }
        public string Expenses { get; set; }
        public string Maintenance { get; set; }
    }
}