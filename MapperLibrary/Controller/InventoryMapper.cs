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
    public class InventoryMapper
    {
        public string InsertOrUpdate(InventoryStockObject _inv, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_stock_Id", _inv.Inventory_Id);
            param.Add("_referenceNumber", _inv.Reference_Number);
            param.Add("_qty", _inv.Quantity);
            param.Add("_restockPoint", _inv.Restock_Point);
            param.Add("_entryDate", _inv.Entry_Date);
            param.Add("_status", _inv.Status);
            param.Add("_item_Id", _inv.Item_Id);
            param.Add("_ftype_Id", _inv.FType_Id);
            param.Add("_unit_Id", _inv.Unit_Id);
            param.Add("_supplier_Id", _inv.Supplier_Id);
            param.Add("_production_Id", _inv.Production_Id);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(InventoryStockObject _inv, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_stock_Id", _inv.Inventory_Id);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(InventoryStockObject _inv, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_search", _inv.Search);
            param.Add("_fromDate", _inv.fromDate);
            param.Add("_toDate", _inv.toDate);
            param.Add("_status", _inv.Status);
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
