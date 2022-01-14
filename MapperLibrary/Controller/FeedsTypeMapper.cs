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
    public class FeedsTypeMapper
    {
        public string InsertOrUpdate(FeedsTypeObject _ftype, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_feedsType_Id", _ftype.FeedsType_Id);
            param.Add("_feedsTypeCode", _ftype.FeedsType_Code);
            param.Add("_description", _ftype.Description);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(FeedsTypeObject _ftype, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_feedsType_Id", _ftype.FeedsType_Id);
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
