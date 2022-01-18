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
    public partial class RelationshipMapper
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

        public string InsertOrUpdate(PersonObject _person, CompanyObject _company, RelationshipObject _relationship, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_person_Id", _person.Id);
            param.Add("_firstName", _person.FirstName);
            param.Add("_lastName", _person.LastName);
            param.Add("_designation", _person.Designation);
            param.Add("_contactNumber", _person.Contact_Number);
            param.Add("_address", _person.Address);
            param.Add("_company_Id", _company.Company_Id);
            param.Add("_companyName", _company.Company_Name);
            param.Add("_companyAddress", _company.Company_Address);
            param.Add("_relationshipType", _relationship.Relationship_Type);
            param.Add("_leadTime", _relationship.Lead_Time);
            param.Add("_buyerStatus", _relationship.Buyer_Status);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(PersonObject _person, CompanyObject _company, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_person_Id", _person.Id);
            param.Add("_company_Id", _company.Company_Id);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(RelationshipObject _relationship, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_relationshipType", _relationship.Relationship_Type);
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
