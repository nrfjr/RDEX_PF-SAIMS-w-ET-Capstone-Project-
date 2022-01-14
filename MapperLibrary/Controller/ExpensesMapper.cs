using Dapper;
using MapperLibrary.Helper;
using ObjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrary.Controller
{
    public class ExpensesMapper
    {
        public string InsertOrUpdate(ExpensesObject _xp, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_expense_Id", _xp.Expense_Id);
            param.Add("_orNumber", _xp.OR_Number);
            param.Add("_expenseType_Id", _xp.ExpenseType_Id);
            param.Add("_amount", _xp.Amount);
            param.Add("_entryDate", _xp.Entry_Date);
            param.Add("_expenseNote", _xp.Expense_Note);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(ExpensesObject _xp, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_expense_Id", _xp.Expense_Id);
            return work.executeNonQuerySP(query, param);
        }
        public string GetScalar(ExpensesObject _xp, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_year", _xp.Year);
            param.Add("_month", _xp.Month);
            return work.returnScalarSP(query, param);

        }
        public List<dynamic> dynamicsListWithParam(ExpensesObject _xp, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_fromDate", _xp.fromDate);
            param.Add("_toDate", _xp.toDate);
            var items = lwork.returnListClass(query, param);
            return items;
        }
        public List<dynamic> dynamicsList(string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            var items = lwork.returnListClass(query, param);
            return items;
        }
    }
}
