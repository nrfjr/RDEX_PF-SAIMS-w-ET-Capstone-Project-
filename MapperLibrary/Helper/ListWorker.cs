using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLibrary;

namespace MapperLibrary.Helper
{
    class ListWorker<T> where T : class
    {
        public MySqlConnection con;
        private void connection()
        {
            con = new MySqlConnection(MySqlDBConnection.stringCon);
        }
        public List<T> returnListClass(string query, DynamicParameters param)
        {

            connection();
            con.Open();
            IList<T> Tlist = SqlMapper.Query<T>(con, query, param, null, true, null, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return Tlist.ToList();

        }
        public T returnClass(string query, DynamicParameters param)
        {

            connection();
            con.Open();
            //     return this.con.Query( query, param, null, true, null, commandType: CommandType.StoredProcedure).FirstOrDefault();
            T Tlist = SqlMapper.Query<T>(con, query, param, null, true, null, commandType: CommandType.StoredProcedure).FirstOrDefault();
            con.Close();
            return Tlist;

        }

    }
}
