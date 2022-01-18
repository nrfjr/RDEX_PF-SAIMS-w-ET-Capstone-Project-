using Dapper;
using MapperLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrary.Controller
{
    public class AuditTrailMapper
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

        public string InsertActivity(int Person_Id, string Activity, string Activity_Type)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_person_Id", Person_Id);
            param.Add("_activity", Activity);
            param.Add("_actType", Activity_Type);
            param.Add("_dateEntry", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm")));
            return work.executeNonQuerySP("RD_Audit_Insert", param);
        }
        public List<dynamic> dynamicsListWithParam(int Person_Id, string Activity_Type, DateTime fromDate, DateTime toDate, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_person_Id", Person_Id);
            param.Add("_actType", Activity_Type);
            param.Add("_dtFrom",fromDate);
            param.Add("_dtTo", toDate);
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
