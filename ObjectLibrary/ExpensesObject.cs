using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{
    public class ExpensesObject
    {
        public int Expense_Id { get; set; }
        public string OR_Number { get; set; }
        public double Amount { get; set; }
        public DateTime Entry_Date { get; set; }
        public int ExpenseType_Id { get; set; }
        public string Expense_Note { get; set; }
        public DateTime toDate { get; set; }
        public DateTime fromDate { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}
