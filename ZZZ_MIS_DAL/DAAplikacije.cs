using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class DAAplikacije
    {
        public static void SelectAplikacijeTotal (DSAplikacije.AplikacijeTotalDataTable dtAplikacijeTotal)
        { 
            dtAplikacijeTotal.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Aplikacije_TotalKandidatiByGodineIMjeseci", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtAplikacijeTotal);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
