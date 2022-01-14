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
    public class ItemMapper
    {
        public string InsertOrUpdate(ItemObject _item, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_item_Id", _item.Item_Id);
            param.Add("_itemCode", _item.Item_Code);
            param.Add("_itemName", _item.Item_Name);
            param.Add("_category_Id", _item.Category_Id);
            param.Add("_description", _item.Description);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(ItemObject _item, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_item_Id", _item.Item_Id);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(ItemObject _item, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_category_Id", _item.Category_Id);
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
