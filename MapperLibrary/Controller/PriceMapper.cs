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
    public class PriceMapper
    {
        public string InsertOrUpdate(PriceObject _price, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_price_Id", _price.Price_Id);
            param.Add("_priceCode", _price.Price_Code);
            param.Add("_priceValue", _price.Price_Value);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(PriceObject _price, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_price_Id", _price.Price_Id);
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
