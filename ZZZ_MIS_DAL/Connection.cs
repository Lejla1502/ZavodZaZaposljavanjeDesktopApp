using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ZZZConnectionString);
            cn.Open();
            return cn;
        }
    }
}
