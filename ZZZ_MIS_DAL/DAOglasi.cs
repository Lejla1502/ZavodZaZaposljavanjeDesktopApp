using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class DAOglasi
    {
        
        public static void SelectOglasiByKompanijaID(DSOglasi.PosaoOglasiDataTable dtOglasi, int kompanijaID)
        {
            dtOglasi.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Oglasi_SelectByKompanijaID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@KompanijaID", SqlDbType.Int).Value = kompanijaID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOglasi);
            }
            finally
            {
                cn.Close();
            }
        }

       

        public static void GetAllOblasti(DSOglasi.OblastiDataTable dtOglasi)
        {
            dtOglasi.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Oblasti_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOglasi);
            }
            finally
            {
                cn.Close();
            }
        }

        
        public static void GetOglasiByDatumIOblast(DSOglasi.PosaoOglasiDataTable dtOglasi, DateTime datumOd, DateTime datumDo, int oblastId)
        {
            dtOglasi.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_OglasiSelectByOblastIDatumObjave", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@datumOd", SqlDbType.Date).Value = datumOd;
                cmd.Parameters.Add("@datumDo", SqlDbType.Date).Value = datumDo;
                if(oblastId!=0)
                cmd.Parameters.Add("@oblastID", SqlDbType.NVarChar).Value = oblastId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOglasi);
            }
            finally
            {
                cn.Close();
            }
        }

        
        public static void SelectOglasiTotal(DSOglasi.OglasiTotalDataTable dtOglasiTotal)
        {
            dtOglasiTotal.Clear();
            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Oglasi_TotalByGodineIMjeseci", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtOglasiTotal);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
