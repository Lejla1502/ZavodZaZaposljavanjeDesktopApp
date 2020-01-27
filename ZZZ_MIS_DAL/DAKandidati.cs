using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZ_MIS_DAL
{
    public class DAKandidati
    {
        
        public static void GetAllDrzave(DSKandidati.DrzaveDataTable dtDrzave)
        {
            dtDrzave.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Drzave_SelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtDrzave);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetKandidatiByIme(DSKandidati.KandidatiDataTable dtKandidati, string Ime, string Prezime, int drzavaID)
        {
            dtKandidati.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Kandidati_SelectByName", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Ime != "")
                    cmd.Parameters.Add("@ime", SqlDbType.NVarChar).Value = Ime;

                if (Prezime != "")
                    cmd.Parameters.Add("@prezime", SqlDbType.NVarChar).Value = Prezime;

                if (drzavaID != 0)
                    cmd.Parameters.Add("@drzavaID", SqlDbType.Int).Value = drzavaID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtKandidati);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void GetProfesijeByKandidatID(DSKandidati.KandidatiProfesijaDataTable dtProfesija, int kandidatID)
        {
            dtProfesija.Clear();

            SqlConnection cn = Connection.GetConnection();

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("usp_Profesije_SelectByKandidatID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("kandidatID", SqlDbType.Int).Value = kandidatID;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtProfesija);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

