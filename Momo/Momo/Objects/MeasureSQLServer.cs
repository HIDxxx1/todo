using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momo.Objects
{
   internal sealed class MeasureSQLServer
    {
        internal void Insert(DateTime dataDate, float analogValue)
        {
            string sql = @"
insert into Measure
(DataDate,
AnalogValue)
values
(@DataDate,
@AnalogValue)
";
            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@DataDate", dataDate));
            p.Add(new SqlParameter("@Analogvalue", analogValue));
            SQLServerHelper.Execute(sql,p.ToArray());
        }
    }
}
