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
    public class ExpenseTypeMapper
    {
        public string InsertOrUpdate(ExpenseTypeObject _xtype, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_expenseType_Id", _xtype.ExpenseType_Id);
            param.Add("_expenseType", _xtype.Expense_Type);
            param.Add("_description", _xtype.Description);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(ExpenseTypeObject _xtype, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_expenseType_Id", _xtype.ExpenseType_Id);
            return work.executeNonQuerySP(query, param);
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
