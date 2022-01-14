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
