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
    public partial class UserMapper
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

        public string InsertOrUpdate(UserObject _user, PersonObject _person, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_person_Id", _person.Id);
            param.Add("_role_Id", _user.Role_Id);
            param.Add("_firstName", _person.FirstName);
            param.Add("_lastName", _person.LastName);
            param.Add("_contactNumber", _person.Contact_Number);
            param.Add("_address", _person.Address);
            param.Add("_userName", _user.UserName);
            param.Add("_password", _user.Password);
            param.Add("_status", _user.Status);
            param.Add("_imagePath", _user.ImagePath);
            return work.executeNonQuerySP(query, param);
        }
        public string Delete(PersonObject _person, string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            param.Add("_person_Id", _person.Id);
            return work.executeNonQuerySP(query, param);
        }
        public List<dynamic> dynamicsListWithParam(UserObject _user, string query)
        {
            DynamicParameters param = new DynamicParameters();
            ListWorker<dynamic> lwork = new ListWorker<dynamic>();
            param.Add("_userName", _user.UserName);
            param.Add("_search", _user.User_Search);
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
