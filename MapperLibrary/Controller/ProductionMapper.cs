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
    public class ProductionMapper
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

        public string Update(ProductionObject _prod, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_production_Id", _prod.Production_Id);
            param.Add("_production_No", _prod.Production_Number);
            param.Add("_pondPrepDate", _prod.Pond_Preparation_Date);
            param.Add("_harvestQty", _prod.Harvest_Quantity);
            param.Add("_harvestDate", _prod.Date_Of_Harvest);
            param.Add("_cropNo", _prod.Crop_Number);
            param.Add("_sr", _prod.Survival_Rate);
            param.Add("_harvestStatus", _prod.Harvest_Status);
            param.Add("_entryStatus", _prod.Entry_Status);
            param.Add("_totalFryStock", _prod.Total_Fry_Stocked);
            param.Add("_dateStocked", _prod.Date_Stocked);
            param.Add("_abw", _prod.Actual_Body_Weight);
            param.Add("_supplier_Id", _prod.Supplier_Id);
            param.Add("_farmName", _prod.Farm_Name);
            param.Add("_samplingDate", _prod.Sampling_Date);
            param.Add("_weeklyFeeds", _prod.Weekly_Cummulative);
            param.Add("_weekNo", _prod.Week_Number);
            param.Add("_labTech", _prod.Lab_Technician);
            param.Add("_sampRefNo", _prod.Sampling_Reference);
            return work.executeNonQuerySP(query, param);
        }
        public string Clear(ProductionObject _prod, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_production_Id", _prod.Production_Id);
            param.Add("_production_No", _prod.Production_Number);
            param.Add("_weekNo", _prod.Week_Number);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(ProductionObject _prod, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_entryStatus", _prod.Entry_Status);
            param.Add("_production_No", _prod.Production_Number);
            param.Add("_pond_Id", _prod.Pond_Id);
            param.Add("_weekNo", _prod.Week_Number);
            param.Add("_farmName", _prod.Farm_Name);
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
