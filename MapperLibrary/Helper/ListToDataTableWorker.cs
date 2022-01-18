using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperLibrary.Helper
{
    public class ListToDataTableWorker
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

        public DataTable ConvertToDataTable(IEnumerable<dynamic> items)
        {

            var t = new DataTable();
            var first = (IDictionary<string, object>)items.First();
            foreach (var k in first.Keys)
            {

                var c = t.Columns.Add(k);
                var val = first[k];
                if (val != null) c.DataType = val.GetType();
            }
            foreach (var item in items)
            {
                try
                {
                    var r = t.NewRow();
                    var i = (IDictionary<string, object>)item;
                    foreach (var k in i.Keys)
                    {
                        var val = i[k];
                        if (val == null) val = DBNull.Value;
                        r[k] = val;
                    }
                    t.Rows.Add(r);
                }
                catch { }
            }
            return t;

        }
    }
}
