using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class DAKompanije
    {

        public static void SelectKompanijeByName(DSKompanije.KompanijeDataTable dtKompanije,int drzavaID, string ImeKompanije,int KategorijaID)
        {
            dtKompanije.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Kompanije_SelectByName", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (ImeKompanije != "")
                    cmd.Parameters.Add("@ImeKompanije", SqlDbType.NVarChar).Value = ImeKompanije;

                if (drzavaID != 0)
                    cmd.Parameters.Add("@DrzavaID", SqlDbType.Int).Value = drzavaID;

                if (KategorijaID != 0)
                    cmd.Parameters.Add("@KategorijaID", SqlDbType.Int).Value = KategorijaID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKompanije);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetAllDrzave(DSKompanije.DrzaveDataTable dtDrzave)
        {
            dtDrzave.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Drzave_SelectAllDrzave", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtDrzave);
            }
            finally
            {
                cn.Close();
            }
        }
        
        public static void GetAllKategorije(DSKompanije.KategorijeDataTable dtKategorije)
        {
            dtKategorije.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Kompanije_SelectALLKategorije", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKategorije);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
