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
    public class SalesAndOrderMapper
    {
        public string InsertOrUpdate(SalesAndOrdersObject _soa, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_order_Id", _soa.Order_Id);
            param.Add("_production_Id", _soa.Production_Id);
            param.Add("_priceCode", _soa.Price_Code);
            param.Add("_customer_Id", _soa.Customer_Id);
            param.Add("_orderQty", _soa.Order_Qty);
            param.Add("_orderStatus", _soa.Order_Status);
            param.Add("_entryDate", _soa.Entry_Date);
            param.Add("_orderRemarks", _soa.Order_Remarks);
            param.Add("_orderOS", _soa.Order_Slip_Number);
            param.Add("_salesAmount", _soa.Sales_Amount);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(SalesAndOrdersObject _soa, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_order_Id", _soa.Order_Id);
            return work.executeNonQuerySP(query, param);
        }

        public List<dynamic> dynamicsListWithParam(SalesAndOrdersObject _soa, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_search", _soa.Search);
            param.Add("_orderStatus", _soa.Order_Status);
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
