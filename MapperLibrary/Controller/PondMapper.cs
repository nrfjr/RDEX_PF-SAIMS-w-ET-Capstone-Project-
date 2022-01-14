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
    public class PondMapper
    {
        public string InsertOrUpdate(PondObject _pond, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_pond_Id", _pond.Pond_Id);
            param.Add("_pondCode", _pond.Pond_Code);
            param.Add("_pondArea", _pond.Pond_Area);
            param.Add("_pondImage", _pond.Pond_Image);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(PondObject _pond, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_pond_Id", _pond.Pond_Id);
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
