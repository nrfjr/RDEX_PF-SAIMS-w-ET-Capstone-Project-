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
    public class QueryWorker
    {
        private MySqlConnection con;

        private void connection()
        {
            con = new MySqlConnection(MySqlDBConnection.stringCon);
        }
        public string executeNonQuerySP(string query, DynamicParameters param)
        {
            try
            {
                connection();
                con.Open();
                con.ExecuteAsync(query, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string executeNonQueryText(string query)
        {
            try
            {
                connection();
                con.Open();
                con.ExecuteAsync(query, commandType: CommandType.Text);
                con.Close();
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string returnScalarSP(string query, DynamicParameters param)
        {
            try
            {
                connection();
                con.Open();
                var valor = con.ExecuteScalar<string>(query, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return valor;
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public string returnScalarText(string query)
        {
            try
            {
                connection();
                con.Open();
                var valor = con.ExecuteScalar<string>(query, commandType: CommandType.Text);
                con.Close();
                return valor;
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public string returnNumericValue(string query, DynamicParameters param)
        {
            try
            {
                string valor = "";
                param.Add("@output", dbType: DbType.Int32, direction: ParameterDirection.Output);
                param.Add("@Returnvalue", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
                connection();
                con.Open();
                valor = con.ExecuteScalar<string>(query, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return valor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public void DeleteAll(string query)
        {
            QueryWorker work = new QueryWorker();
            DynamicParameters param = new DynamicParameters();
            work.executeNonQueryText(query);
        }

        public static bool IsExist(string table, string column, string value)
        {
            bool result = false;
            QueryWorker getScalar = new QueryWorker();
            result = Int32.Parse(getScalar.returnScalarText($"SELECT COUNT(*) FROM {table} WHERE {column} = '{value}'")) > 0;
            return result;
        }
    }
}
