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
    public class PrivilegeMapper
    {
        //------------------------------------------------------------------------------
        // <strictly-required>
        //     This code was strictly required for the program.
        //     Runtime Version:4.0.30319.42000
        //
        //     Changes to this file may cause incorrect behavior and will be lost if
        //     the code is modified or missing.
        // </strictly-required>
        //------------------------------------------------------------------------------

        public string InsertOrUpdate(PrivilegeObject _privilege,  string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_role_Id", _privilege.Role_Id);
            param.Add("_dashboard", _privilege.Dashboard);
            param.Add("_customer", _privilege.Customer);
            param.Add("_supplier", _privilege.Supplier);
            param.Add("_items", _privilege.Items);
            param.Add("_feedsType", _privilege.Feeds_Type);
            param.Add("_expenseType", _privilege.Expense_Type);
            param.Add("_pricing", _privilege.Pricing);
            param.Add("_pond", _privilege.Ponds);
            param.Add("_pondPlanEntry", _privilege.Pond_Plan_Entry);
            param.Add("_pondWeeklyUpdate", _privilege.Pond_Weekly_Updates);
            param.Add("_pondResult", _privilege.Pond_Results);
            param.Add("_availableStock", _privilege.Available_Stock);
            param.Add("_criticalStock", _privilege.Critical_Stock);
            param.Add("_materialRequest", _privilege.Material_Request);
            param.Add("_stockReceiving", _privilege.Stock_Receiving);
            param.Add("_stockWithdrawal", _privilege.Stock_Withdrawal);
            param.Add("_salesEntry", _privilege.Sales_Entry);
            param.Add("_expenses", _privilege.Expenses);
            param.Add("_maintenance", _privilege.Maintenance);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(PrivilegeObject _privilege, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_role_Id", _privilege.Role_Id);
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
